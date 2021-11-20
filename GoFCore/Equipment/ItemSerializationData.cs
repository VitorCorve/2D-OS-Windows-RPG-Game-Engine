using System.Collections.Generic;

namespace GameEngine.Equipment
{
    public class ItemSerializationData
    {
        public int[] ID { get; set; }
        public int[] ItemDurability { get; set; }
        public void PrepareToSerialize(List<ItemEntity> itemsList)
        {
            if (itemsList is null || itemsList.Count == 0) return;

            ID = new int[itemsList.Count];
            ItemDurability = new int[itemsList.Count];
            int count = 0;

            foreach (var item in itemsList)
            {
                ID[count] = item.Model.ID;
                ItemDurability[count] = item.ItemDurability.Value;
                count++;
            }
        }
        public List<ItemEntity> ConvertToInventoryItemsList()
        {
            if (ID is null || ID.Length == 0)
            {
                var emtpyItemsList = new List<ItemEntity> { };
                return emtpyItemsList;
            }
            var itemsList = new List<ItemEntity> { };

            for (int i = 0; i < ID.Length; i++)
            {
                itemsList.Add(new ItemEntity((ID[i]), ItemDurability[i], WEARED_STATUS.Inventory));
            }
            return itemsList;
        }
        public List<ItemEntity> ConvertToWearedEquipmentItemsList()
        {
            if (ID is null || ID.Length == 0)
            {
                var emtpyItemsList = new List<ItemEntity> { };
                return emtpyItemsList;
            }
            var itemsList = new List<ItemEntity> { };

            for (int i = 0; i < ID.Length; i++)
            {
                itemsList.Add(new ItemEntity((ID[i]), ItemDurability[i], WEARED_STATUS.Weared));
            }
            return itemsList;
        }
    }
}
