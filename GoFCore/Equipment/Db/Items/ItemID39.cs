using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID39 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 39;

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
            int id = 39;
            string itemName = "Lamellar waist";
            var quality = ITEM_QUALITY.Rare;
            var equipmentType = EQUIPMENT_TYPE.Waist;
            var price = new CostValue(48);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Lamellar\\Waist.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
