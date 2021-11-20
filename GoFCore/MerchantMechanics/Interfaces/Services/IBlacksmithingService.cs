using GameEngine.Equipment;
using GameEngine.Inventory;

namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface IBlacksmithingService
    {
        int PlayerAbsoluteMoneyValue { get; }
        int LocationValueMultiplier { get; }
        bool PermissionToRepair { get; }
        int RepairCostValue { get; }
        void RepairWearedEquipment(WearedEquipment equipment);
        void RepairInventoryItems(PlayerInventoryItemsList playerInventory);
        void SetRepairCostValue(ItemEntity item);
        void SetRepairCostValue(WearedEquipment equipment);
        void RepairItem(ItemEntity item);
    }
}
