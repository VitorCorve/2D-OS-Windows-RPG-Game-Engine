using GameEngine.BattleMaster.Interfaces;
using GameEngine.BattleMaster.Services;
using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.CombatEngine.Services;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.NPC;
using GameEngine.NPC.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.BattleMaster
{
    public class BattleMaster : IBattleMaster
    {
        private bool BattleIsOver;
        public delegate void Notification();
        public event Notification BattleFinished;
        public event Notification GameOver;
        private readonly NPC_CreationManager NPC_CreationManager;
        public List<ObserverService> Observers { get; private set; } = new List<ObserverService> { };
        public AutoAttackMaster AutoAttack { get; private set; }
        public CombatManager PlayerCombatManager { get; private set; }
        public List<ISkill> SkillList { get; private set; }
        public WearedEquipment PlayerEquipment { get; private set; }
        public BattleMaster(PlayerSaveData playerSaveData)
        {
            var playerModelData = new PlayerModelData(playerSaveData);
            var wearedEquipment = new WearedEquipment(playerSaveData.ItemsOnCharacter.ConvertToInventoryItemsList());
            var playerEntityConstructor = new PlayerEntityConstructor();
            NPC_CreationManager = new NPC_CreationManager(playerModelData);
            var equipmentValues = new EquipmentValue(wearedEquipment);
            PlayerEquipment = wearedEquipment;

            var playerEntity = playerEntityConstructor.CreatePlayer(playerSaveData);

            var npcEntity = playerEntityConstructor.CreatePlayer(
                NPC_CreationManager.NPC_Model,
                NPC_CreationManager.NPC);

            var playerCombatManager = new CombatManager(dealer: playerEntity, target: npcEntity);
            var npcCombatManager = new CombatManager(dealer: npcEntity, target: playerEntity);

            AutoAttack = new AutoAttackMaster(
                dealerCombatManager: playerCombatManager,
                targetCombatManager: npcCombatManager);

            var observerService = new ObserverService(playerCombatManager, playerModelData, NPC_CreationManager.NPC_Model, SERVICE_OWNER.Player);
            var observerService2 = new ObserverService(npcCombatManager, NPC_CreationManager.NPC_Model, playerModelData, SERVICE_OWNER.Enemy);

            Observers.Add(observerService);
            Observers.Add(observerService2);


            PlayerCombatManager = playerCombatManager;
            SkillList = playerSaveData.PlayerSkills.Skills;
            PlayerCombatManager.Dealer.CharacterDied += StopFight;
            PlayerCombatManager.Target.CharacterDied += StopFight;
        }
        public void StartFight()
        {
            AutoAttack.RunAutoAttack();
        }
        public void StopFight()
        {
            AutoAttack.StopAutoAttack();
            if (BattleIsOver == false) BattleIsOver = true;
            else return;
            var durabilityManager = new DurabilityManager();
            PlayerEquipment = durabilityManager.DecreaseDurabilityAfterFight(PlayerEquipment);

            if (PlayerCombatManager.Dealer.HealthPoints.Value > 0)
                BattleFinished?.Invoke();
            else
                GameOver?.Invoke();
        }
        public void Pause()
        {

        }

        public void UseSkill(int skillIndex)
        {
            PlayerCombatManager.Action(SkillList[skillIndex]);
        }
        public INPC_Enemy GetNPCEntity() => NPC_CreationManager.NPC;
        public INPC_ModelData GetNPCModel() => NPC_CreationManager.NPC_Model;
    }
}
