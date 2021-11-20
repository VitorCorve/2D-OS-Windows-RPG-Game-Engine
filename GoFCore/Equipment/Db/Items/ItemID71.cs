using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID71 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 71;

            attributes.Stamina = 5;
            attributes.Strength = 3;
            attributes.Intellect = 3;
            attributes.Endurance = 2;
            attributes.Agility = 3;
            attributes.Endurance = 2;
            attributes.ArmorValue = 7;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 71;
            string itemName = "Majestic boots";
            var quality = ITEM_QUALITY.Legendary;
            var equipmentType = EQUIPMENT_TYPE.Boots;
            var price = new CostValue(75);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Majesty\\Boots.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
