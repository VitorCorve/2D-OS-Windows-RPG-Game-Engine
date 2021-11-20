using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.NPC;
using GameEngine.Player;

namespace GameEngine.CombatEngine.Services
{
    public class ObserverService
    {
        public delegate void NotifyMaster(ACTION_TYPE actionType, string message, SERVICE_OWNER owner, ISkill skill = null);
        public event NotifyMaster Log;
        public SERVICE_OWNER Owner;
        public string DealerName { get; set; }
        public string TargetName { get; set; }
        public int Player1Level { get; set; }
        public int Player2Level { get; set; }

        public ObserverService(CombatManager player1Manager, PlayerModelData player1ModelData, PlayerModelData player2ModelData, SERVICE_OWNER serviceOwner)
        {
            BindEvents(player1Manager);

            DealerName = player1ModelData.Name;
            TargetName = player2ModelData.Name;
            Player1Level = player1ModelData.Level;
            Player2Level = player2ModelData.Level;

            Owner = serviceOwner;
        }
        public ObserverService(CombatManager player1Manager, NPC_ModelData npcModelData, PlayerModelData playerModelData, SERVICE_OWNER serviceOwner)
        {
            BindEvents(player1Manager);

            DealerName = npcModelData.Name.ToString();
            TargetName = playerModelData.Name;
            Player1Level = npcModelData.Level;
            Player2Level = playerModelData.Level;

            Owner = serviceOwner;
        }

        public ObserverService(CombatManager player1Manager, PlayerModelData playerModelData, NPC_ModelData npcModelData, SERVICE_OWNER serviceOwner)
        {
            BindEvents(player1Manager);

            DealerName = playerModelData.Name;
            TargetName = npcModelData.Name.ToString();
            Player1Level = playerModelData.Level;
            Player2Level = npcModelData.Level;

            Owner = serviceOwner;
        }
        private void BindEvents(CombatManager combatManager)
        {
            combatManager.Ready.Log += ConstructReadyNotification;
            combatManager.Defense.Log += ConstructDefenseNotification;
            combatManager.Combat.LogDamage += ConstructCombatDamageNotification;
            combatManager.Combat.LogBuff += ConstructCombatBuffNotification;
            combatManager.Combat.LogDebuff += ConstructCombatDebuffNotification;
            combatManager.Target.LogDotDamage += ConstructCombatDoTNotification;
            combatManager.Target.LogSpecialDamage += ConstructCombatSpecialDamageNotification;
            combatManager.Combat.LogDeath += ConstructCharacterDeathNotification;
        }
        private void ConstructReadyNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, DealerName + $" {str}", Owner, skill);
        private void ConstructDefenseNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, TargetName + $" {str}", SERVICE_OWNER.Enemy, skill);
        private void ConstructCombatDamageNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, DealerName + $" {str} to " + TargetName, Owner, skill);
        private void ConstructCombatBuffNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, DealerName + $" {str}", Owner, skill);
        private void ConstructCombatDebuffNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, DealerName + $" {str} on " + TargetName, Owner, skill);
        private void ConstructCombatDoTNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, DealerName + $"'s {str} to " + TargetName, Owner, skill);
        private void ConstructCombatSpecialDamageNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, $"{DealerName}'s {str} " + TargetName + "!", Owner, skill);
        public void ConstructCharacterDeathNotification(ACTION_TYPE actionType, string str, ISkill skill = null) => Log(actionType, $"{TargetName} {str}", SERVICE_OWNER.Enemy, skill);
    }
}
