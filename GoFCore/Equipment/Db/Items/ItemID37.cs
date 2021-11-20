using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID37 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 37;

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
            int id = 37;
            string itemName = "Lamellar bracers";
            var quality = ITEM_QUALITY.Rare;
            var equipmentType = EQUIPMENT_TYPE.Bracers;
            var price = new CostValue(47);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Lamellar\\Bracers.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
