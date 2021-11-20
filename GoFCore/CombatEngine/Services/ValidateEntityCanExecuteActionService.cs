using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.PlayerConditions;
using System.Collections.Generic;

namespace GameEngine.CombatEngine
{
    public class ValidateEntityCanExecuteActionService : IValidateEntityCanExecuteAction
    {
        public delegate void NotifyMaster(ACTION_TYPE actionType, string message, ISkill skill = null);
        public event NotifyMaster Log;
        public PlayerControl OutOfControl { get; set; } = new PlayerControl();
        public bool IsAlive { get; private set; } = true;
        public List<IConditionResourceType> Resources { get; private set; } = new List<IConditionResourceType> { };
        public ValidateEntityCanExecuteActionService(PlayerEntity dealer)
        {
            OutOfControl = dealer.OutOfControl;

            if (dealer.HealthPoints.Value <= 0) IsAlive = false;

            Resources.Add(dealer.ManaPoints);
            Resources.Add(dealer.EnergyPoints);
        }

        public bool CheckStatement(ISkill skill)
        {
            if (IsAlive == false)
            {
                Log?.Invoke(ACTION_TYPE.Death, "is dead");
                return false;
            }
            if (OutOfControl.Value)
            {
                Log?.Invoke(ACTION_TYPE.Out_Of_Control, "is out of control");
                return false;
            }

            if (skill?.CoolDown > 0)
            {
                Log?.Invoke(ACTION_TYPE.Cool_Down, $"{skill.SkillName} on cooldown. Cooldown: {skill.CoolDown} s.", skill);
                return false;
            }

            foreach (var resource in Resources)
            {
                if (resource.GetType() == (skill.ResourceType.GetType()))
                {
                    if (skill?.Cost > resource.Value)
                    {
                        Log?.Invoke(GetResourceActionType(resource), $"has not enought {resource.Name}");
                        return false;
                    }
                    break;
                }
            }
            return true;
        }
        private static ACTION_TYPE GetResourceActionType(IConditionResourceType conditionResource)
        {
            return conditionResource switch
            {
                Energy => ACTION_TYPE.Not_Enought_Energy,
                Mana => ACTION_TYPE.Not_Enought_Mana,
                _ => ACTION_TYPE.Not_Enought_Health,
            };
        }
    }
}
