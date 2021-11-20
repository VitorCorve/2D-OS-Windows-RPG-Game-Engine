using System.Collections.Generic;

namespace GameEngine.Equipment.Db.Items
{
    public class ItemsMetaData
    {
        public const int TotalItemsCountInEngineByMaxIndex = 2;
        public List<ItemEntity> ItemsTotal { get; set; } = new();
        public ItemsMetaData()
        {
            for (int i = 4; i < 77; i++)
                ItemsTotal.Add(new ItemEntity(i));
        }
    }
}
