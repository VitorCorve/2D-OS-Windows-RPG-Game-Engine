using GameEngine.Equipment.Db.Items.Interfaces;
using GameEngine.Equipment.Resource;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID1 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 1;

            attributes.Stamina = 10;
            attributes.Strength = 10;
            attributes.Intellect = 10;
            attributes.Endurance = 10;
            attributes.Agility = 10;
            attributes.Endurance = 10;
            attributes.ArmorValue = 100;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 1;
            string itemName = "Best Shoulders Gear";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.Shoulder;
            var price = new CostValue(100);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\shoulder.png";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
