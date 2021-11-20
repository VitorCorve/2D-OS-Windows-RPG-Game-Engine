using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID67 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 67;

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
            int id = 67;
            string itemName = "Majestic bracers";
            var quality = ITEM_QUALITY.Legendary;
            var equipmentType = EQUIPMENT_TYPE.Bracers;
            var price = new CostValue(71);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Majesty\\Bracers.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
