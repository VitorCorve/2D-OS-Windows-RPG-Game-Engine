using GameEngine.Equipment;
using GameEngine.MerchantMechanics.Interfaces.Services;
using GameEngine.Player;

namespace GameEngine.MerchantMechanics.Services
{
    public class TradingService : ITradingService
    {
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public TradingService(PlayerConsumablesData playerConsumables) => PlayerConsumables = playerConsumables;
        public void IncreasePlayerMoneyValue(int value) => PlayerConsumables.IncreaseValue(value);
        public void DecreasePlayerMoneyValue(int value) => PlayerConsumables.DecreaseValue(value);
    }
}