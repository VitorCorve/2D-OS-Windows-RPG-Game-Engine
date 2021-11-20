using GameEngine.Player.ConsumableResources;

namespace GameEngine.Abstract
{
    public interface IPlayerConsumablesData
    {
        Copper CopperValue { get; }
        Silver SilverValue { get; }
        Gold GoldValue { get; }
        SkillPoints SkillPointsValue { get; }
        AttributePoints AttributePointsValue { get; }
        void ConvertToZero();
    }
}
