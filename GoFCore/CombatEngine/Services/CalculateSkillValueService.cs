using GameEngine.Player.ConditionResources;
using System;

namespace GameEngine.CombatEngine.Services
{
    public class CalculateSkillValueService
    {
        public int SkillValue { get; private set; }
        public CalculateSkillValueService(CriticalHitChance criticalChance, int basicSkillValue)
        {
            Random randomize = new Random();

            if (criticalChance == null)
                criticalChance = new CriticalHitChance(0.0);

            if (randomize.Next(0, 100) < criticalChance.Value)
                basicSkillValue *= 3;

            SkillValue = basicSkillValue * 10 / randomize.Next(9, 12);
        }
    }
}
