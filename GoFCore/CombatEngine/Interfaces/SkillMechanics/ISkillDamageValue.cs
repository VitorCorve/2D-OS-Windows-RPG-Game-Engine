using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.CombatEngine.Interfaces.SkillMechanics
{
    public interface ISkillDamageValue
    {
        int RandomizeDamageValue(int damageValue);
    }
}
