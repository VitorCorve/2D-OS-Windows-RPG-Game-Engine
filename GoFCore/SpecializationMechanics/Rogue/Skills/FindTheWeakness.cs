using GameEngine.CombatEngine;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using System;
using static GameEngine.CombatEngine.Interfaces.ISkill;

namespace GameEngine.SpecializationMechanics.Rogue.Skills
{
    public class FindTheWeakness : IDebuffSkill
    {
        public event CoolDownObserver NotifyCooldownStart;
        public event CoolDownObserver NotifyCooldownEnd;
        public event CoolDownObserver NotifyHarmEffectAppears;
        public event CoolDownObserver NotifyHarmEffectFade;
        public int Skill_ID { get; } = 9;
        public string SkillName { get; private set; } = "Find the weakness";
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
        public int Duration { get; set; } = 12;
        public int ActiveDuration { get; set; }
        public int CoolDownDuration { get; set; } = 20;
        public int CoolDown { get; set; }
        public int Cost { get; private set; }
        public int AmountOfValue { get; private set; }
        public int AvailableAtLevel { get; } = 16;
        public IResourceType ResourceType { get; set; } = new Mana();
        public IUseType Type { get; set; } = new Magic();
        public int Power { get; set; }
        public void Use(int dealerAttackPower, PlayerEntity target)
        {
            Random chanceOfLethalDamage = new Random();

            if (chanceOfLethalDamage.Next(0, 100) < 10)
                target.ReceivePercentOfDamage(90, this);

            var buffService = new BuffsService(this, target);
            var coolDown = new CoolDownService(this);

            buffService.Activate(() => target.ReceiveDebuff(PLAYER_DEBUFF.FindTheWeakness));
            coolDown.Activate();

            NotifyHarmEffectAppears?.Invoke(this);
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
