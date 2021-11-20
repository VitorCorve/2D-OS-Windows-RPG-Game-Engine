using GameEngine.Inventory;

namespace GameEngine.Equipment.Interfaces
{
    public interface IDurablityManager
    {
        WearedEquipment DecreaseDurabilityAfterFight(WearedEquipment equipment);
        void RecoverWearedEquipment(WearedEquipment equipment);
        void RecoverInventoryItems(PlayerInventoryItemsList playerInventory);
        int CalculateRepairValue(WearedEquipment equipment);
        int CalculateRepairValue(PlayerInventoryItemsList playerInventory);
    }
}
