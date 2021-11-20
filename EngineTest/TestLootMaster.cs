using GameEngine.Data.Services;
using GameEngine.Inventory;
using GameEngine.LootMaster;
using GameEngine.Player;
using System;

namespace EngineTest
{
    public class TestLootMaster
    {
        public TestLootMaster()
        {
            string workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var dataSerializer = new SaveDataJsonDeserializer();
            var loadGameService = new LoadGameService();
            var playerSaveData = dataSerializer.Deserialize($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\Missiswarrior.json");
            var playerInventoryItemsList = new PlayerInventoryItemsList(playerSaveData.ItemsInInventory.ConvertToInventoryItemsList()); ;

            playerSaveData.Level = 10;

            var playerModelData = new PlayerModelData(playerSaveData);

            var lootMaster = new LootMaster(playerModelData.PlayerGrade, playerInventoryItemsList, playerModelData.PlayerConsumables);


            Console.WriteLine("Player inventory items before looting: ");

            foreach (var item in playerInventoryItemsList.ItemsInInventory)
                Console.WriteLine("\t" + item.Model.ItemName);
            Console.Write("\tMoney: " + playerSaveData.Money);

            lootMaster.ThrowItems();

            Console.WriteLine("\nLoot: ");
            foreach (var item in lootMaster.Loot)
            {
                Console.WriteLine(item.Model.ItemName);
            }
            Console.Write("Money: " + lootMaster.MoneyReward + "\n");

            for (int i = 0; i < lootMaster.Loot.Count; i++)
                lootMaster.PickUpItem(i);

            Console.WriteLine("\nPlayer inventory items after looting: ");

            foreach (var item in playerInventoryItemsList.ItemsInInventory)
                Console.WriteLine("\t" + item.Model.ItemName);
            Console.Write("\tMoney: " + playerModelData.PlayerConsumables.AbsoluteMoneyValue);
        }
    }
}
