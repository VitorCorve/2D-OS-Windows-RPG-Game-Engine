using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using GameEngine.Player.DefenseResources;
using System.Collections.Generic;
using GameEngine.CombatEngine.Services;
using GameEngine.CombatEngine.Actions;

namespace GameEngine.CombatEngine
{
    public partial class PlayerEntity : IPlayerEntity, IReceiveDamage, IReceiveHeal, IOutOfControl
    {
        public delegate void NotifyMaster(ACTION_TYPE actionType, string message, ISkill skill = null);
        public delegate void NotifyAdditional();
        public event NotifyMaster LogDotDamage;
        public event NotifyMaster LogSpecialDamage;
        public event NotifyAdditional CharacterDied;
        public Health HealthPoints { get; set; }
        public Mana ManaPoints { get; set; }
        public Energy EnergyPoints { get; set; }
        public AttackPower Attack { get; set; }
        public DefensePower Defense { get; set; } = new DefensePower();
        public Armor ArmorPoints { get; set; }
        public CriticalHitChance CriticalChance { get; set; }
        public Dodge DodgeChance { get; set; }
        public Block BlockChance { get; set; }
        public Parry ParryChance { get; set; }
        public Resist ResistChance { get; set; }
        public PlayerControl OutOfControl { get; set; } = new PlayerControl();
        public List<PLAYER_DEBUFF> Debuffs { get; set; } = new List<PLAYER_DEBUFF> {};
        public RecoveryService RecoverResources { get; set; }
        public Immortality IsMortal { get; set; } = new();
        public void ReceiveDamage(int incomingDamage)
        {
            if (WillSurvive(incomingDamage))
            {
                HealthPoints.Value -= incomingDamage;
            }
            else
            {
                HealthPoints.Value = 0;
                CharacterDied?.Invoke();
            }
        }
        public void SetValue(IResourceType valueType, double value)
        {
            switch (valueType)
            {
                case DefensePower:
                    Defense.IncomingDamageDivider = value;
                    return;
                case AttackPower:
                    Attack.OutcomingDamageMultiplier = value;
                    return;
                case CriticalHitChance:
                    CriticalChance.Value = value;
                    return;
                case Armor:
                    ArmorPoints.Value = (int)value;
                    return;
                case Dodge:
                    DodgeChance.Value = value;
                    return;
                case Block:
                    BlockChance.Value = value;
                    return;
                case Parry:
                    ParryChance.Value = value;
                    return;
                case Resist:
                    ResistChance.Value = value;
                    return;
                default:
                    break;
            }
        }
        public void ReduceResource(ISkill skill)
        {
            switch (skill.ResourceType)
            {
                case Mana:
                    ManaPoints.Value -= skill.Cost;
                    return;
                case Energy:
                    EnergyPoints.Value -= skill.Cost;
                    return;
                default:
                    break;
            }
        }
        public void ReceiveDamgeOverTime(ISkill skill, int incomingDamage)
        {
            if (WillSurvive(incomingDamage))
            {
                LogDotDamage(ACTION_TYPE.Dot_Damage, $"{skill.SkillName} deals {incomingDamage} damage", skill);
                HealthPoints.Value -= incomingDamage;
            }
            else
            {
                CharacterDied?.Invoke();
                HealthPoints.Value = 0;
            }
        }
        public void ReceivePercentOfDamage(int percent, ISkill skill)
        {
            LogSpecialDamage(ACTION_TYPE.Special_Damage, $"{skill.SkillName} mutilates", skill);

            double health = HealthPoints.Value;
            health -= (health / 100 * percent);
            HealthPoints.Value = (int)health;
        }
        public void ReceiveHeal(int healAmount) => HealthPoints.Value += healAmount;
        private bool WillSurvive(int damageValue) => HealthPoints.Value - damageValue > 0;
        public void LoseControl() => OutOfControl.Value = true;
        public void ReturnControl() => OutOfControl.Value = false;
        public void ReceiveDebuff(PLAYER_DEBUFF debuff) => Debuffs.Add(debuff);
        public void RemoveDebuff(PLAYER_DEBUFF debuff) => Debuffs.Remove(debuff);
    }
}
