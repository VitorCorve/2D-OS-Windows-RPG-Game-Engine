using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID0 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 0;

            attributes.Stamina = 10;
            attributes.Strength = 10;
            attributes.Intellect = 10;
            attributes.Endurance = 10;
            attributes.Agility = 10;
            attributes.Endurance = 10;
            attributes.ArmorValue = 100;
            attributes.WeaponDamageValue = 6;
            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 0;
            string itemName = "Magic Warglaive Item";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.Right;
            var price = new CostValue(100);
            var avatarPath =$"{Environment.CurrentDirectory}\\Data\\Images\\items\\warglaive.png";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
