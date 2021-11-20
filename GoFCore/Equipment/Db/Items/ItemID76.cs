using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID76 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 76;

            attributes.Stamina = 7;
            attributes.Strength = 3;
            attributes.Intellect = 3;
            attributes.Endurance = 4;
            attributes.Agility = 4;
            attributes.Endurance = 2;
            attributes.ArmorValue = 7;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 76;
            string itemName = "Relict of old Secrets";
            var quality = ITEM_QUALITY.Legendary;
            var equipmentType = EQUIPMENT_TYPE.Artefact;
            var price = new CostValue(78);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Majesty\\Artefact.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
