using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.LootMaster.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;
using System.Linq;
using System;
using GameEngine.Equipment.Db.Items;

namespace GameEngine.LootMaster
{
    public class LootMaster : ILootMaster
    {
        private readonly ITEM_QUALITY ItemQuality;
        public PlayerInventoryItemsList Inventory { get; private set; }
        public PlayerConsumablesData Consumables { get; private set; }
        public List<ItemEntity> ProbableLootList { get; private set; }
        public List<ItemEntity> Loot { get; private set; } = new();
        public int MoneyReward { get; private set; }
        public static ITEM_QUALITY GetItemsQuality(PLAYER_GRADE playerGrade)
        {
            switch (playerGrade)
            {
                case PLAYER_GRADE.Novice:
                    return ITEM_QUALITY.Poor;
                case PLAYER_GRADE.Advanced:
                    return ITEM_QUALITY.Poor;
                case PLAYER_GRADE.Adept:
                    return ITEM_QUALITY.Good;
                case PLAYER_GRADE.Expert:
                    return ITEM_QUALITY.Rare;
                case PLAYER_GRADE.Master:
                    return ITEM_QUALITY.Epic;
                default:
                    return ITEM_QUALITY.Legendary;
            }
        }
        public LootMaster(PLAYER_GRADE playerGrade, PlayerInventoryItemsList playerInventory, PlayerConsumablesData consumablesData)
        {
            ItemQuality = GetItemsQuality(playerGrade);

            Inventory = playerInventory;
            Consumables = consumablesData;

            PrepareLoot();
        }
        public void ThrowItems()
        {
            Random randomize = new Random();

            if (ProbableLootList.Count <= 0)
            {
                MoneyReward = randomize.Next(0, 1000);
                return;
            }

            if (ProbableLootList.Count > 0)
                MoneyReward = ProbableLootList.First().Model.Price.AbsoluteMoneyValue;
            else
                MoneyReward = randomize.Next(0, 1000);

            Consumables.AbsoluteMoneyValue += MoneyReward;

            Loot.Add(ProbableLootList[randomize.Next(0, ProbableLootList.Count - 1)]);

            if (randomize.Next(0, ProbableLootList.Count) > (ProbableLootList.Count / 2))
                Loot.Add(ProbableLootList[randomize.Next(0, ProbableLootList.Count - 1)]);
        }
        public void PickUpItem(int index)
        {
            Inventory.AddItem(Loot[index]);
            Loot.RemoveAt(index);
        }
        public void PickUpAllItems()
        {
            foreach (var item in Loot)
                Inventory.AddItem(item);
        }
        public void PrepareLoot()
        {
            var itemsMetaData = new ItemsMetaData();
            ProbableLootList = new List<ItemEntity>();
            foreach (var item in itemsMetaData.ItemsTotal)
            {
                if (item.Model.Quality == ItemQuality)
                    ProbableLootList.Add(item);
            }
        }
    }
}
