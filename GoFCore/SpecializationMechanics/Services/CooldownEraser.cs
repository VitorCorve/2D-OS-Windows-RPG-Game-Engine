using GameEngine.CombatEngine.Interfaces;
using System.Collections.Generic;

namespace GameEngine.SpecializationMechanics.Services
{
    public static class CooldownEraser
    {
        public static void Clean(List<ISkill> skills)
        {
            foreach (var item in skills)
            {
                item.CoolDown = 0;
            }
        }
    }
}
