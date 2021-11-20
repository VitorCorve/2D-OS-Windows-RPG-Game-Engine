using System;
using GameEngine.Equipment.Db.Items.Interfaces;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID30 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 30;

            attributes.Stamina = 3;
            attributes.Strength = 1;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 4;
            attributes.WeaponDamageValue = 2;

            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 30;
            string itemName = "Iron dagger";
            var quality = ITEM_QUALITY.Good;
            var equipmentType = EQUIPMENT_TYPE.Left;
            var price = new CostValue(44);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Leather\\Dagger.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
