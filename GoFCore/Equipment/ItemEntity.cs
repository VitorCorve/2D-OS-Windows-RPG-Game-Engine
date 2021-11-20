using GameEngine.Equipment.Db;
using GameEngine.Equipment.Resource;

namespace GameEngine.Equipment
{
    public class ItemEntity
    {
        public ItemAttributes Attributes { get; private set; }
        public ItemModel Model { get; private set; }
        public Durability ItemDurability { get; set; } = new();
        public ItemEntity(int id)
        {
            var itemCreator = new ItemModelCreator();
            var itemAttributesCreator = new ItemAttributesCreator();

            Attributes = itemAttributesCreator.CreateAttributesByID(id);
            Model = itemCreator.CreateModelByID(id);

            ItemDurability.Value = 100;
        }
        public ItemEntity(int id, int itemDurability)
        {
            var itemCreator = new ItemModelCreator();
            var itemAttributesCreator = new ItemAttributesCreator();

            Attributes = itemAttributesCreator.CreateAttributesByID(id);
            Model = itemCreator.CreateModelByID(id);

            ItemDurability.Value = itemDurability;
        }
        public ItemEntity(int id, int itemDurability, WEARED_STATUS wearedStatus)
        {
            var itemCreator = new ItemModelCreator();
            var itemAttributesCreator = new ItemAttributesCreator();

            Attributes = itemAttributesCreator.CreateAttributesByID(id);
            Model = itemCreator.CreateModelByID(id);
            Model.Status = wearedStatus;
            ItemDurability.Value = itemDurability;
        }
        public ItemEntity()
        {

        }
    }
}
