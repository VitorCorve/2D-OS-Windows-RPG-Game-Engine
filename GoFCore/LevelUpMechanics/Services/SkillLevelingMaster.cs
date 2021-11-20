using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;

namespace GameEngine.LevelUpMechanics.Services
{
    public class SkillLevelingMaster
    {
        public int PlayerLevel { get; set; }
        public PlayerConsumablesData PlayerConsumables { get; private set; }
        public SkillLevelingMaster(PlayerModelData playerModel)
        {
            PlayerConsumables = playerModel.PlayerConsumables;
            PlayerLevel = playerModel.Level;
        }
        public void LevelUp(ISkill skill)
        {
            if (skill.AvailableAtLevel < PlayerLevel) return;
            if (PlayerConsumables.SkillPointsValue.Value > 0)
            {
                PlayerConsumables.SkillPointsValue.Value --;
                skill.SkillLevel ++;
            }
        }
    }
}
