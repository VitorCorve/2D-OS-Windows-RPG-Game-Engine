using GameEngine.Equipment;
using System.Collections.Generic;

namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface IPricesConverter
    {
        List<ItemEntity> Convert(double multiplier, List<ItemEntity> itemsList);
    }
}
