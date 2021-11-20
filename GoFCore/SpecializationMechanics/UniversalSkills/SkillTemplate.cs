using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.SpecializationMechanics.UniversalSkills
{
    public class SkillTemplate : ISkill
    {
        public int Skill_ID { get; set; }
        public string SkillName { get; set; }
        public int SkillLevel { get; set; }
        public int CoolDownDuration { get; set; }
        public int CoolDown { get; set; }
        public int Cost { get; set; }
        public int AmountOfValue { get; set; }
        public int AvailableAtLevel { get; set; }
        public int Power { get; set; }
        public IResourceType ResourceType { get; set; }
        public IUseType Type { get; set; }

        public event ISkill.CoolDownObserver NotifyCooldownStart;
        public event ISkill.CoolDownObserver NotifyCooldownEnd;
        public void CoolDownEnd() { }
        public void Use(int dealerAttackPower, PlayerEntity target) { }
        public void ForceCoolDown() { }
    }
}
