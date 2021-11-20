using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID61 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 61;

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
            int id = 61;
            string itemName = "Fallen star dust";
            var quality = ITEM_QUALITY.Epic;
            var equipmentType = EQUIPMENT_TYPE.Artefact;
            var price = new CostValue(70);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Ebony\\Artefact.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
