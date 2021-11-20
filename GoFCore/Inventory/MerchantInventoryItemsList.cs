using GameEngine.Equipment;
using GameEngine.Inventory.Interfaces;
using GameEngine.Locations;
using System;
using System.Collections.Generic;

namespace GameEngine.Inventory
{
    public class MerchantInventoryItemsList : IInventoryItemsList
    {
        public List<ItemEntity> ItemsInInventory { get; set; } = new();
        public MerchantInventoryItemsList(List<ItemEntity> collection)
        {
            foreach (var item in collection)
                ItemsInInventory.Add(item);
        }
        public MerchantInventoryItemsList(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                itemEntity.Model.Status = WEARED_STATUS.Inventory;
                ItemsInInventory.Add(itemEntity);
            }
        }
        public void AddItem(ItemEntity item) => ItemsInInventory.Add(item);
        public void RemoveItem(ItemEntity item)
        {
            var itemEntity = new ItemEntity();
            foreach (var inventoryItem in ItemsInInventory)
            {
                if (inventoryItem.Model.ID == item.Model.ID && inventoryItem.ItemDurability.Value == item.ItemDurability.Value)
                {
                    itemEntity = inventoryItem;
                }
            }
            ItemsInInventory.Remove(itemEntity);
        }
    }
}
