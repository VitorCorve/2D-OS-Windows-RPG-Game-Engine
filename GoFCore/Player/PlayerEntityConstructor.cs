using GameEngine.CombatEngine.Services;
using GameEngine.Data;
using GameEngine.Equipment;
using GameEngine.EquipmentManagement;
using GameEngine.NPC;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ConditionResources;
using GameEngine.Player.DefenseResources;

namespace GameEngine.CombatEngine
{
    public class PlayerEntityConstructor
    {
        // player creation method overloads
        public PlayerEntity CreatePlayer(PlayerSaveData saveData)
        {
            var wearedEquipment = new WearedEquipment(saveData.ItemsOnCharacter.ConvertToWearedEquipmentItemsList());
            var equipmentValues = new EquipmentValue(wearedEquipment);
            var playerModel = new PlayerModelData(saveData);
            var playerEntity = new PlayerEntity
            {
                HealthPoints = new Health((saveData.PlayerAttributes.Stamina + equipmentValues.Stamina) * 10),
                ManaPoints = new Mana((saveData.PlayerAttributes.Intellect + equipmentValues.Intellect) * 10),
                EnergyPoints = new Energy((saveData.PlayerAttributes.Agility + equipmentValues.Agility) * 10),
                ArmorPoints = new Armor(saveData.PlayerAttributes.ArmorValue),
                DodgeChance = new Dodge(((saveData.PlayerAttributes.Agility + equipmentValues.Agility) / 2) + saveData.Level),
                ParryChance = new Parry(((saveData.PlayerAttributes.Agility + equipmentValues.Agility) / 2.2) + saveData.Level),
                BlockChance = new Block(((saveData.PlayerAttributes.Agility + equipmentValues.Agility) / 1.8) + saveData.Level),
                ResistChance = new Resist((saveData.PlayerAttributes.Intellect / 2) + saveData.Level),
            };

            playerEntity.HealthPoints.Value = saveData.PlayerHealthValue;
            playerEntity.ManaPoints.Value = saveData.PlayerManaValue;
            playerEntity.EnergyPoints.Value = saveData.PlayerEnergyValue;

            playerEntity = ConvertSpecializationBindedValues(playerEntity, saveData.Specialization, saveData.PlayerAttributes, playerModel);

            var playerRecovery = new RecoveryService(playerEntity.HealthPoints, playerEntity.ManaPoints, playerEntity.EnergyPoints);

            playerEntity.RecoverResources = playerRecovery;

            return playerEntity;
        }
        public PlayerEntity CreatePlayer(PlayerModelData modelData, IEntityAttributes specializationAttributes, IEntityAttributes equipmentValues)
        {
            var playerEntity = new PlayerEntity
            {
                HealthPoints    = new Health((specializationAttributes.Stamina          + equipmentValues.Stamina)   * 10),
                ManaPoints      = new Mana((specializationAttributes.Intellect          + equipmentValues.Intellect) * 10),
                EnergyPoints    = new Energy((specializationAttributes.Agility          + equipmentValues.Agility)   * 10),
                ArmorPoints     = new Armor(equipmentValues.ArmorValue),
                DodgeChance     = new Dodge(((specializationAttributes.Agility          + equipmentValues.Agility)   / 2)   + modelData.Level),
                ParryChance     = new Parry(((specializationAttributes.Agility          + equipmentValues.Agility)   / 2.2) + modelData.Level),
                BlockChance     = new Block(((specializationAttributes.Agility          + equipmentValues.Agility)   / 1.8) + modelData.Level),
                ResistChance    = new Resist((specializationAttributes.Intellect / 2)   + modelData.Level),
            };

            playerEntity = ConvertSpecializationBindedValues(playerEntity, modelData.Specialization, specializationAttributes, modelData);

            var playerRecovery = new RecoveryService(playerEntity.HealthPoints, playerEntity.ManaPoints, playerEntity.EnergyPoints);

            playerEntity.RecoverResources = playerRecovery;

            return playerEntity;
        }

        // NPC creation method overload
        public PlayerEntity CreatePlayer(NPC_ModelData modelData, IEntityAttributes specializationAttributes)
        {
            var playerEntity = new PlayerEntity
            {
                HealthPoints   = new Health((specializationAttributes.Stamina) * 10),
                ManaPoints     = new Mana((specializationAttributes.Intellect) * 10),
                EnergyPoints   = new Energy((specializationAttributes.Agility) * 10),
                ArmorPoints    = new Armor(specializationAttributes.ArmorValue),
                DodgeChance    = new Dodge(((specializationAttributes.Agility) / 2) + modelData.Level),
                ParryChance    = new Parry(((specializationAttributes.Agility) / 2.2) + modelData.Level),
                BlockChance    = new Block(((specializationAttributes.Agility) / 1.8) + modelData.Level),
                ResistChance   = new Resist((specializationAttributes.Intellect / 2) + modelData.Level),
                CriticalChance = new CriticalHitChance(specializationAttributes.Agility + modelData.Level),
                Attack         = new AttackPower((specializationAttributes.Strength * 2)),
            };

            var playerRecovery = new RecoveryService(playerEntity.HealthPoints, playerEntity.ManaPoints, playerEntity.EnergyPoints);

            playerEntity.RecoverResources = playerRecovery;
            if (playerEntity.DodgeChance.Value > 30)
                playerEntity.DodgeChance.Value = 30;

            if (playerEntity.ParryChance.Value > 30)
                playerEntity.ParryChance.Value = 30;

            if (playerEntity.BlockChance.Value > 30)
                playerEntity.BlockChance.Value = 30;

            if (playerEntity.ResistChance.Value > 30)
                playerEntity.ResistChance.Value = 30;

            return playerEntity;
        }
        public PlayerEntity CreatePlayer(PlayerModelData modelData, IEntityAttributes specializationAttributes)
        {
            var playerEntity = new PlayerEntity
            {
                HealthPoints = new Health(specializationAttributes.Stamina * 10),
                ManaPoints = new Mana(specializationAttributes.Intellect * 10),
                EnergyPoints = new Energy(specializationAttributes.Agility * 10),
                ArmorPoints = new Armor(0),
                DodgeChance = new Dodge((specializationAttributes.Agility / 2) + modelData.Level),
                ParryChance = new Parry((specializationAttributes.Agility / 2.2) + modelData.Level),
                BlockChance = new Block((specializationAttributes.Agility / 1.8) + modelData.Level),
                ResistChance = new Resist((specializationAttributes.Intellect / 2) + modelData.Level),
            };

            playerEntity = ConvertSpecializationBindedValues(playerEntity, modelData.Specialization, specializationAttributes, modelData);

            var playerRecovery = new RecoveryService(playerEntity.HealthPoints, playerEntity.ManaPoints, playerEntity.EnergyPoints);

            playerEntity.RecoverResources = playerRecovery;

            return playerEntity;
        }
        private PlayerEntity ConvertSpecializationBindedValues(PlayerEntity playerEntity, SPECIALIZATION specialization, IEntityAttributes specializationAttributes, PlayerModelData modelData)
        {
            switch (specialization)
            {
                case SPECIALIZATION.Mage:
                    playerEntity.CriticalChance = new CriticalHitChance(specializationAttributes.Intellect + modelData.Level);
                    playerEntity.Attack = new AttackPower(specializationAttributes.Intellect * 2);
                    break;
                default:
                    playerEntity.CriticalChance = new CriticalHitChance((specializationAttributes.Agility + modelData.Level) / 2);
                    playerEntity.Attack = new AttackPower((specializationAttributes.Strength * 2));
                    break;
            }
            return playerEntity;
        }
    }
}
