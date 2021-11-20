using GameEngine.Equipment;
using System.Collections.Generic;

namespace GameEngine.Inventory.Interfaces
{
    public interface IInventoryItemsList
    {
        const int MaxItemsInInventory = 32;
        List<ItemEntity> ItemsInInventory { get; }
        void AddItem(ItemEntity item);
        void RemoveItem(ItemEntity item);
    }
}
