using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID43 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 43;

            attributes.Stamina = 3;
            attributes.Strength = 2;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 1;
            attributes.Endurance = 1;
            attributes.ArmorValue = 5;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 43;
            string itemName = "Lamellar cloak";
            var quality = ITEM_QUALITY.Rare;
            var equipmentType = EQUIPMENT_TYPE.Cloak;
            var price = new CostValue(50);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Lamellar\\Cloak.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
