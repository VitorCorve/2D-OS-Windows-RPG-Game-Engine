using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID35 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 35;

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
            int id = 35;
            string itemName = "Lamellar shoulders";
            var quality = ITEM_QUALITY.Rare;
            var equipmentType = EQUIPMENT_TYPE.Shoulder;
            var price = new CostValue(30);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Lamellar\\Shoulders.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
