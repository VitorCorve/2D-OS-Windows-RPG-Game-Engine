using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID48 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 48;

            attributes.Stamina = 4;
            attributes.Strength = 2;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 2;
            attributes.Endurance = 1;
            attributes.ArmorValue = 6;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 48;
            string itemName = "Ebony helmet";
            var quality = ITEM_QUALITY.Epic;
            var equipmentType = EQUIPMENT_TYPE.Helmet;
            var price = new CostValue(62);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Ebony\\Helmet.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
