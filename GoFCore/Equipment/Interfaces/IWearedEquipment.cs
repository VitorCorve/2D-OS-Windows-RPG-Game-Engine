using GameEngine.Equipment.Resource;
using GameEngine.EquipmentManagement;
using System.Collections.Generic;

namespace GameEngine.Equipment.Interfaces
{
    public interface IWearedEquipment
    {
        List<ItemEntity> ItemsList { get; }
        void Wear(ItemEntity item);
        void RemoveItem(ItemEntity item);
        EquipmentValue ToEquipmentValues();
    }
}
