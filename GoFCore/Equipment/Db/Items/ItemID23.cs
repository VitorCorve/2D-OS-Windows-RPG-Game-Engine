using System;
using GameEngine.Equipment.Db.Items.Interfaces;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID23 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 23;

            attributes.Stamina = 3;
            attributes.Strength = 1;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 4;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 23;
            string itemName = "Leather gloves";
            var quality = ITEM_QUALITY.Good;
            var equipmentType = EQUIPMENT_TYPE.Gloves;
            var price = new CostValue(41);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Leather\\Gloves.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
