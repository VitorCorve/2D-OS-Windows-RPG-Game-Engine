using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Mage.Skills
{
    public class Soulburn : IDamageOverTimeSkill
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyHarmEffectAppears;
        public event CoolDownObserver NotifyHarmEffectFade;
        public int Skill_ID { get; } = 6;
        public string SkillName { get; private set; } = "Soul Burn";
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
        public int Duration { get;  set; } = 10;
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 12;
        public int CoolDown { get; set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int Cost { get; private set; }
        public int Intervals { get; private set; } = 2;
        public int SkillDamageValue { get; set; }
        public int AmountOfValue { get; private set; }
        public int DealedDamage { get; set; }
        public int AvailableAtLevel { get; } = 16;
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();
        public int Power { get; set; }

        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = (dealerAttackPower + Power) * target.Defense.IncomingDamageDivider;
            int finalDamage = (int)incomingDamage;

            var damageOverTimeService = new DamageOverTimeService(target, this);
            var coolDown = new CoolDownService(this);
            damageOverTimeService.Activate();
            coolDown.Activate();

            NotifyHarmEffectAppears?.Invoke(this);
            NotifyCooldownStart?.Invoke(this);
            DealedDamage = finalDamage;
        }
        private void ConvertValues()
        {
            Cost = SkillLevel * 3;
            AmountOfValue = SkillLevel * 5;
            Power = AmountOfValue;
            SkillDamageValue = AmountOfValue;
        }
        public void CoolDownEnd()
        {
            NotifyCooldownEnd?.Invoke(this);
        }
        public void HarmEffectEnd()
        {
            NotifyHarmEffectFade?.Invoke(this);
        }
        public void ForceCoolDown()
        {
            var coolDown = new CoolDownService(this);
            coolDown.Activate();
        }
    }
}
