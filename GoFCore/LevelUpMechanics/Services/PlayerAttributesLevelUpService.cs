using GameEngine.Player;
using GameEngine.Player.Abstract;

namespace GameEngine.LevelUpMechanics.Services
{
    public class PlayerAttributesLevelUpService
    {
        public IEntityAttributes PlayerAttributes { get; private set; }
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public PlayerAttributesLevelUpService(IEntityAttributes playerAttributes, PlayerModelData playerModel)
        {
            PlayerAttributes = playerAttributes;
            PlayerConsumables = playerModel.PlayerConsumables;
        }

        public void UpgradeStrength() => PlayerAttributes.Strength += 1;
        public void UpgradeStamina() => PlayerAttributes.Stamina += 1;
        public void UpgradeEndurance() => PlayerAttributes.Endurance += 1;
        public void UpgradeIntellect() => PlayerAttributes.Intellect += 1;
        public void UpgradeAgility() => PlayerAttributes.Agility += 1;
    }
}
