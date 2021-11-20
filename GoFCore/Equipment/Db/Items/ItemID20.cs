using GameEngine.Equipment.Db.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemID20 : ICreationItemModel
    {
        public ItemAttributes GetAttributes()
        {
            var attributes = new ItemAttributes();

            attributes.ID = 20;

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
            int id = 20;
            string itemName = "Leather shoulders";
            var quality = ITEM_QUALITY.Good;
            var equipmentType = EQUIPMENT_TYPE.Shoulder;
            var price = new CostValue(42);
            var avatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\items\\Leather\\Shoulders.jpg";

            return new ItemModel(id, itemName, quality, equipmentType, price, avatarPath);
        }
    }
}
