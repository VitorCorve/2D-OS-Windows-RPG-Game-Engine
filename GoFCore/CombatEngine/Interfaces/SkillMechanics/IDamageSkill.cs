using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDamageSkill : ISkill, ICriticalChance
    {
        int DealedDamage { get; set; }
        int SkillDamageValue { get; }
    }
}
