using GameEngine.Equipment;
using GameEngine.MerchantMechanics.Interfaces.Services;
using System.Collections.Generic;

namespace GameEngine.MerchantMechanics.Services
{
    public class PricesConverter : IPricesConverter
    {
        public List<ItemEntity> Convert(double multiplier, List<ItemEntity> itemsList)
        {
            foreach (var item in itemsList)
            {
                item.Model.Price.ConvertValues((int)(item.Model.Price.AbsoluteMoneyValue * multiplier));
            }
            return itemsList;
        }
    }
}
