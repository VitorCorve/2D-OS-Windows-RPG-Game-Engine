using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Warrior.Skills
{
    public class WideBlow : IDamageSkill, ISkillDamageValue, IDebuffSkill, IBuffResourceType
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyHarmEffectAppears;
        public event CoolDownObserver NotifyHarmEffectFade;
        public int Skill_ID { get; } = 16;
        public string SkillName { get; private set; } = "Wide blow";
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
        public int Duration { get; set; } = 8;
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 15;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public int DealedDamage { get; set; }
        public int AvailableAtLevel { get; } = 4;
        public IResourceType ResourceType { get; set; } = new Energy();
        public IUseType Type { get; set; } = new Melee();
        public IResourceType BuffResourceType { get; set; } = new Health();
        public int Power { get; set; }
        public CriticalHitChance CriticalChance { get; private set; }
        public int SkillDamageValue
        {
            get { return RandomizeDamageValue(_skillDamageValue); }
            private set { _skillDamageValue = value; }
        }
        private int _skillDamageValue;

        public int RandomizeDamageValue(int damageValue)
        {
            var skillValueValidation = new CalculateSkillValueService(CriticalChance, damageValue);
            return skillValueValidation.SkillValue;
        }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            CriticalChance = target.CriticalChance;
            double incomingDamage = ((dealerAttackPower + SkillDamageValue) - target.ArmorPoints.Value) * target.Defense.IncomingDamageDivider;
            int finalDamage = (int)incomingDamage;

            if (finalDamage < (target.ArmorPoints.Value / 10))
                finalDamage = target.ArmorPoints.Value / 10;

            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);
            coolDown.Activate();

            buffService.Activate(() => target.RecoverResources.StopRecover(BuffResourceType));

            target.ReceiveDamage(finalDamage);

            NotifyCooldownStart?.Invoke(this);
            NotifyHarmEffectAppears?.Invoke(this);
            DealedDamage = finalDamage;
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
