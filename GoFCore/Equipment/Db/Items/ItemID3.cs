using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID3 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 3;

            attributes.Stamina = 2;
            attributes.Strength = 1;
            attributes.Intellect = 1;
            attributes.Endurance = 1;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 3;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 3;
            string itemName = "Hide helmet";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.Helmet;
            var price = new CostValue(30);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\sword.png";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
