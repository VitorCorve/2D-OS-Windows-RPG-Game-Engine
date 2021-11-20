using GameEngine.Equipment.Interfaces;
using GameEngine.Inventory;

namespace GameEngine.Equipment
{
    public class DurabilityManager : IDurablityManager
    {
        public WearedEquipment DecreaseDurabilityAfterFight(WearedEquipment equipment)
        {
            foreach (var item in equipment.ItemsList)
                item.ItemDurability.Decrease(5);
            return equipment;
        }
        public void RecoverWearedEquipment(WearedEquipment equipment)
        {
            foreach (var item in equipment.ItemsList)
                item.ItemDurability.Increase(100);
        }
        public void RecoverInventoryItems(PlayerInventoryItemsList playerInventory)
        {
            foreach (var item in playerInventory.ItemsInInventory)
                item.ItemDurability.Increase(100);
        }
        public static void RecoverItem(ItemEntity item)
        {
            item.ItemDurability.Increase(100);
        }
        public int CalculateRepairValue(WearedEquipment equipment)
        {
            int repairvalue = 0;
            foreach (var item in equipment.ItemsList)
                repairvalue += 100 - item.ItemDurability.Value;
            return repairvalue;
        }
        public int CalculateRepairValue(PlayerInventoryItemsList playerInventory)
        {
            int repairvalue = 0;
            foreach (var item in playerInventory.ItemsInInventory)
                repairvalue += 100 - item.ItemDurability.Value;
            return repairvalue;
        }
        public static int CalculateRepairValue(ItemEntity item) => 100 - item.ItemDurability.Value;
    }
}
