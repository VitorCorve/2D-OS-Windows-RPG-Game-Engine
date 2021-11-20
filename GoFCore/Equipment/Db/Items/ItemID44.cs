using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID44 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 44;

            attributes.Stamina = 3;
            attributes.Strength = 2;
            attributes.Intellect = 2;
            attributes.Endurance = 2;
            attributes.Agility = 1;
            attributes.Endurance = 1;
            attributes.ArmorValue = 5;
            attributes.WeaponDamageValue = 5;

            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 44;
            string itemName = "Steel sword";
            var quality = ITEM_QUALITY.Rare;
            var equipmentType = EQUIPMENT_TYPE.Right;
            var price = new CostValue(58);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Lamellar\\Sword.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
