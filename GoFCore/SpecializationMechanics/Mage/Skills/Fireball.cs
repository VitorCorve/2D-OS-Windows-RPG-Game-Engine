using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Fireball : IDamageSkill, ISkillDamageValue
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public int Skill_ID { get; } = 2;
        public string SkillName { get; private set; } = "Fireball";
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
        public int SkillDamageValue { get; set; }
        private int _skillDamageValue;
        public int AmountOfValue { get; private set; }
        public int DealedDamage { get; set; }
        public int AvailableAtLevel { get; } = 1;
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();
        public int Power { get; set; }

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = (RandomizeDamageValue(dealerAttackPower + SkillDamageValue)) * target.Defense.IncomingDamageDivider;
            int finalDamage = (int)incomingDamage;
            target.ReceiveDamage(finalDamage);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
            NotifyCooldownStart?.Invoke(this);
            DealedDamage = finalDamage;
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            SkillDamageValue = SkillLevel * 5;
            Power = SkillDamageValue;
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
