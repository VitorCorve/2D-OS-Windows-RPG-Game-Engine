using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class PowerHit : IDamageSkill, ISkillDamageValue
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public int Skill_ID { get; } = 15;
        public string SkillName { get; private set; } = "Power hit";
        public int SkillLevel
        {
            get { return _SkillLevel; }
            set
            {
                _SkillLevel = value;
                ConvertValues();
            }
        }
        private int _SkillLevel;
        public int CoolDownDuration { get; set; } = 3;
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int Cost { get; private set; }

        private int _skillDamageValue;
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        public int AmountOfValue { get; private set; }
        public int AvailableAtLevel { get; } = 1;
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public int Power { get; set; }
        public int DealedDamage { get; set; }
        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = ((dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;

            if (incomingDamage < target.ArmorPoints.Value / 15)
            {
                incomingDamage = target.ArmorPoints.Value / 15;
            }

            DealedDamage = (int)incomingDamage;

            if (AmountOfValue < (target.ArmorPoints.Value / 10))
                AmountOfValue = target.ArmorPoints.Value / 10;

            target.ReceiveDamage(DealedDamage);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            NotifyCooldownStart?.Invoke(this);
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
            Power = AmountOfValue;
        }
        public void CoolDownEnd()
        {
            NotifyCooldownEnd?.Invoke(this);
        }
        public void ForceCoolDown()
        {
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }
    }
}
