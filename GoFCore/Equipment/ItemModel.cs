using GameEngine.Equipment.Db.Models;
using System;

namespace GameEngine.Equipment
{
    public class ItemModel
    {
        public readonly string ItemAvatarPath;
        public readonly int ID;
        public readonly string ItemName;
        public readonly ITEM_QUALITY Quality;
        public readonly EQUIPMENT_TYPE WearType;
        public readonly CostValue Price;
        public WEARED_STATUS Status;
        public ItemModel(int id, string itemName, ITEM_QUALITY quality, EQUIPMENT_TYPE wearType, CostValue price, string avatarPath = null)
        {
            ID = id;
            ItemName = itemName;
            Quality = quality;
            WearType = wearType;
            Price = price;
            ItemAvatarPath = avatarPath ?? null;
        }
        public ItemModel(ItemModelDB itemModel)
        {
            ID = itemModel.ID;
            ItemName = itemModel.ItemName;
            Quality = (ITEM_QUALITY)Enum.Parse(typeof(ITEM_QUALITY), itemModel.Quality);
            WearType = (EQUIPMENT_TYPE)Enum.Parse(typeof(EQUIPMENT_TYPE), itemModel.WearType);
            Price = new CostValue(itemModel.Price);
        }
    }
}
