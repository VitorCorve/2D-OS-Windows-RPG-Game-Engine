using GameEngine.Equipment.Interfaces;
using GameEngine.EquipmentManagement;
using System.Collections.Generic;

namespace GameEngine.Equipment
{
    public class WearedEquipment : IWearedEquipment
    {
        public virtual List<ItemEntity> ItemsList { get; set; } = new();
        public void Wear(ItemEntity item)
        {
            item.Model.Status = WEARED_STATUS.Weared;
            ItemsList.Add(item);
        }
        public void RemoveItem(ItemEntity item)
        {
            var itemEntity = new ItemEntity();
            foreach (var itemInItemList in ItemsList)
            {
                if (itemInItemList.Model.ID == item.Model.ID && itemInItemList.ItemDurability.Value == item.ItemDurability.Value)
                {
                    itemEntity = itemInItemList;
                    break;
                }
            }
            ItemsList.Remove(itemEntity);
        }
        public EquipmentValue ToEquipmentValues() => new EquipmentValue(this);
        public WearedEquipment(params int[] id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                var itemEntity = new ItemEntity(id[i]);
                itemEntity.Model.Status = WEARED_STATUS.Weared;
                ItemsList.Add(itemEntity);
            }
        }
        public WearedEquipment(List<ItemEntity> itemsList)
        {
            foreach (var item in itemsList)
            {
                ItemsList.Add(item);
            }
        }
        public WearedEquipment()
        {

        }
    }
}
