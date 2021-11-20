using GameEngine.Equipment.Db.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID10 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 10;

            attributes.Stamina = 2;
            attributes.Strength = 1;
            attributes.Intellect = 1;
            attributes.Endurance = 1;
            attributes.Agility = 0;
            attributes.Endurance = 0;
            attributes.ArmorValue = 3;

            attributes.SetItemLevel();
            return attributes;
        }
        public ItemModel GetModel()
        {
            int id = 10;
            string itemName = "Hide pants";
            var quality = ITEM_QUALITY.Poor;
            var equipmentType = EQUIPMENT_TYPE.Pants;
            var price = new CostValue(32);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Hide\\Pants.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
