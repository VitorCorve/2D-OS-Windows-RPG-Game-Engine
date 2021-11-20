using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Interfaces.SkillMechanics;
using System;
using System.Timers;

namespace GameEngine.SpecializationMechanics.UniversalSkills
{
    public class RecoverResource : IRecoveryResourceSkill
    {
        public double RecoveryValue { get; }
        public Timer RecoveryTimer { get; private set; } = new Timer(2000);
        public IConditionResourceType ResourceType { get; set; }
        public void Recover()
        {
            RecoveryTimer.Elapsed += TimerTick;
            RecoveryTimer.Start();
        }

        public RecoverResource(IConditionResourceType resource)
        {
            ResourceType = resource;
            Recover();
            RecoveryValue = RecoveryTimer.Interval/1000;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (ResourceType.Value > 0)
            {
                if (ResourceType.Value / 100 < 1)
                    ResourceType.Value += 1;
                else
                    ResourceType.Value += ResourceType.Value / 100;
            }
            else
                RecoveryTimer.Stop();
        }

        public void StopRecover()
        {
            RecoveryTimer.Stop();
        }

        public void ContinueRecover()
        {
            RecoveryTimer.Start();
        }
    }
}
