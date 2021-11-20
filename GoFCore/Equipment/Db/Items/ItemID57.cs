using GameEngine.Equipment.Db.Items.Interfaces;
using System;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID57 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 57;

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
            int id = 57;
            string itemName = "Ebony ring";
            var quality = ITEM_QUALITY.Epic;
            var equipmentType = EQUIPMENT_TYPE.Ring;
            var price = new CostValue(60);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Ebony\\Ring.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
