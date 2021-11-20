using System;
using GameEngine.Equipment.Db.Items.Interfaces;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID31 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 31;

            attributes.Stamina = 3;
            attributes.Strength = 1;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 4;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 31;
            string itemName = "Shiny stone";
            var quality = ITEM_QUALITY.Good;
            var equipmentType = EQUIPMENT_TYPE.Artefact;
            var price = new CostValue(48);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Leather\\Artefact.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
