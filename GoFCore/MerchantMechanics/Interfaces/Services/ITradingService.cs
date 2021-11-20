using GameEngine.Equipment;
using GameEngine.Player;

namespace GameEngine.MerchantMechanics.Interfaces.Services
{
    public interface ITradingService
    {
        PlayerConsumablesData PlayerConsumables { get; }
        void IncreasePlayerMoneyValue(int value);
        void DecreasePlayerMoneyValue(int value);
    }
}
