using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.UniversalSkills
{
    public class RegularAttack : IDamageSkill, ISkillDamageValue
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public int Skill_ID { get; } = 2;
        public string SkillName { get; private set; } = "melee attack";
        public int SkillLevel { get; set; }
        public int Duration { get; set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get; private set; } = new CriticalHitChance();
        public int Cost { get; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        public int AmountOfValue { get; private set; }
        public int DealedDamage { get; set; }
        public int AvailableAtLevel { get; } = 0;
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public int Power { get; set; }
        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            SkillDamageValue = dealerAttackPower;
            double incomingDamage = ((SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;
            AmountOfValue = (int)incomingDamage;

            if (AmountOfValue < (target.ArmorPoints.Value / 10))
                AmountOfValue = target.ArmorPoints.Value / 10;

            target.ReceiveDamage(AmountOfValue);
            DealedDamage = AmountOfValue;
        }
        public void CoolDownEnd()
        {
        }
        public void ForceCoolDown()
        {
        }
    }
}
