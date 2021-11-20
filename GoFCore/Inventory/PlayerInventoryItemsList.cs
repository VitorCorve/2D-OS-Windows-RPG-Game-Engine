using GameEngine.Equipment;
using GameEngine.Inventory.Interfaces;
using GameEngine.Locations;
using System;
using System.Collections.Generic;

namespace GameEngine.Inventory
{
    public class PlayerInventoryItemsList : IInventoryItemsList
    {
        public const int MaxItemsInInventory = 48;
        public List<ItemEntity> ItemsInInventory { get; set; } = new();
        public PlayerInventoryItemsList(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                itemEntity.Model.Status = WEARED_STATUS.Inventory;
                ItemsInInventory.Add(itemEntity);
            }
        }
        public void AddRange(List<ItemEntity> itemsList)
        {
            foreach (var item in itemsList)
            {
                item.Model.Status = WEARED_STATUS.Inventory;
                ItemsInInventory.Add(item);
            }
                
        }
        public void AddItem(ItemEntity item)
        {
            if (ItemsInInventory.Count >= MaxItemsInInventory)
                throw new Exception("No empty slots in inventory");
            else
            {
                item.Model.Status = WEARED_STATUS.Inventory;
                ItemsInInventory.Add(item);
            }
        }
        public void RemoveItem(ItemEntity item)
        {
            var itemEntity = new ItemEntity();
            foreach (var inventoryItem in ItemsInInventory)
            {
                if (inventoryItem.Model.ID == item.Model.ID && inventoryItem.ItemDurability.Value == item.ItemDurability.Value)
                {
                    itemEntity = inventoryItem;
                    break;
                }
            }
            ItemsInInventory.Remove(itemEntity);
        }
        public PlayerInventoryItemsList(List<ItemEntity> itemsList) => ItemsInInventory = itemsList;
        public PlayerInventoryItemsList() 
        {
        }
    }
}
