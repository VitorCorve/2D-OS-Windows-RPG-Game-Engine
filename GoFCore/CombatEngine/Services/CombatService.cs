using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.Player.ConditionResources;

namespace GameEngine.CombatEngine
{
    public class CombatServiсe : IWeaponAttack
    {
        public delegate void NotifyMaster(ACTION_TYPE actionType, string message, ISkill skill = null);
        public event NotifyMaster LogDamage;
        public event NotifyMaster LogBuff;
        public event NotifyMaster LogDebuff;
        public event NotifyMaster LogDeath;
        public delegate void ExecuteAction();
        public delegate bool CheckAction();
        public AttackPower DamageValue { get; private set; }
        public int OutComingDamage { get; private set; }
        public CombatServiсe(PlayerEntity dealer)
        {
            DamageValue = dealer.Attack;
        }

        public void Execute(PlayerEntity target)
        {
            target.ReceiveDamage(DamageValue.Value - target.ArmorPoints.Value);
        }
        public void Execute(PlayerEntity target, ISkill skill)
        {
            skill.Use(DamageValue.Value, target);

            switch (skill)
            {
                case ICombinedSkill:
                    LogBuff(ACTION_TYPE.Buff, $"uses {skill.SkillName} for {((IBuffSkill)skill).Duration} second", skill);
                    break;
                case IDamageSkill:
                    LogDamage(ACTION_TYPE.Damage, $"deals {((IDamageSkill)skill).DealedDamage} damage by {skill.SkillName}", skill);
                    break;
                case IBuffSkill:
                    LogBuff(ACTION_TYPE.Buff, $"uses {skill.SkillName} for {((IBuffSkill)skill).Duration} second", skill);
                    break;
                case IDebuffSkill:
                    LogDebuff(ACTION_TYPE.Debuff, $"uses {skill.SkillName} for {((IDebuffSkill)skill).Duration} second", skill);
                    break;
                case IHealSkill:
                    LogBuff(ACTION_TYPE.Buff, $"recovers {skill.AmountOfValue} health by Heal", skill);
                    break;
                default:
                    break;
            }

            if (target.HealthPoints.Value <= 0)
                LogDeath(ACTION_TYPE.Death, $"died");
        }
    }
}
