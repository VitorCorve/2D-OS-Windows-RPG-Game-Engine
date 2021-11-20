using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.MerchantMechanics.Interfaces.Services;

namespace GameEngine.MerchantMechanics.Services
{
    public class BlacksmithingService : IBlacksmithingService
    {
        public int PlayerAbsoluteMoneyValue { get; set; }
        public int LocationValueMultiplier { get; set; } = 1;
        public bool PermissionToRepair { get; private set; } = false;
        public int RepairCostValue { get; private set; } = 0;
        public void RepairItem(ItemEntity item)
        {
            RepairCostValue *= LocationValueMultiplier;
            ValidateMoneyValue();

            if (!PermissionToRepair)
                return;

            SetRepairCostValue(item);
            DurabilityManager.RecoverItem(item);
        }
        public void RepairWearedEquipment(WearedEquipment equipment)
        {
            RepairCostValue *= LocationValueMultiplier;
            ValidateMoneyValue();

            if (!PermissionToRepair)
                return;

            var durabilityManager = new DurabilityManager();

            SetRepairCostValue(equipment);
            durabilityManager.RecoverWearedEquipment(equipment);
        }
        public void RepairInventoryItems(PlayerInventoryItemsList playerInventory)
        {
            RepairCostValue *= LocationValueMultiplier;
            ValidateMoneyValue();

            if (!PermissionToRepair)
                return;

            var durabilityManager = new DurabilityManager();

            SetRepairCostValue(playerInventory);
            durabilityManager.RecoverInventoryItems(playerInventory);
        }
        public void ValidateMoneyValue()
        {
            if (PlayerAbsoluteMoneyValue >= RepairCostValue)
                PermissionToRepair = true;
            else
                PermissionToRepair = false;
        }
        public void SetRepairCostValue(WearedEquipment equipment)
        {
            var durabilityManager = new DurabilityManager();
            RepairCostValue = durabilityManager.CalculateRepairValue(equipment);
        }
        public void SetRepairCostValue(PlayerInventoryItemsList playerInventory)
        {
            var durabilityManager = new DurabilityManager();
            RepairCostValue = durabilityManager.CalculateRepairValue(playerInventory);
        }
        public void SetRepairCostValue(ItemEntity item) => RepairCostValue = DurabilityManager.CalculateRepairValue(item);
    }
}
