using System;
using System.Collections.Generic;
using GameEngine.Equipment.Db.Items.Interfaces;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID29 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 29;

            attributes.Stamina = 3;
            attributes.Strength = 1;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 4;
            attributes.WeaponDamageValue = 4;

            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 29;
            string itemName = "Iron sword";
            var quality = ITEM_QUALITY.Good;
            var equipmentType = EQUIPMENT_TYPE.Right;
            var price = new CostValue(48);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Leather\\Sword.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
