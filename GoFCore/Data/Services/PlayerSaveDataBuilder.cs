using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Data.Interfaces.Services;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Locations.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Data.Interfaces
{
    public class PlayerSaveDataBuilder : IPlayerSaveDataBuilder
    {
        public PlayerSaveData Build(PlayerModelData playerModelData, ILocation currentLocation, PlayerInventoryItemsList inventoryItems, WearedEquipment wearedItems, PlayerSkillList skills, IEntityAttributes playerAttributes, List<ISkill> UISkillPlacementData, PlayerEntity characterEntity = null)
        {
            var playerSaveData = new PlayerSaveData();

            playerSaveData.AvailableAttributePoints = playerModelData.PlayerConsumables.AttributePointsValue.Value;
            playerSaveData.AvailableSkillPoints = playerModelData.PlayerConsumables.SkillPointsValue.Value;
            playerSaveData.AvatarPath = playerModelData.AvatarPath;
            playerSaveData.Bio = playerModelData.Bio;
            playerSaveData.CurrentTown = currentLocation.Town;
            playerSaveData.Experience = playerModelData.Experience;
            playerSaveData.MaxExperience = playerModelData.MaxExperience;
            playerSaveData.Gender = playerModelData.Gender;
            playerSaveData.ItemsInInventory.PrepareToSerialize(inventoryItems.ItemsInInventory);
            playerSaveData.ItemsOnCharacter.PrepareToSerialize(wearedItems.ItemsList);
            playerSaveData.Level = playerModelData.Level;
            playerSaveData.Money = playerModelData.PlayerConsumables.AbsoluteMoneyValue;
            playerSaveData.Name = playerModelData.Name;
            playerSaveData.PlayerSkills = skills;
            playerSaveData.Specialization = playerModelData.Specialization;
            playerSaveData.PlayerAttributes = playerAttributes;
            playerSaveData.UISkillPlacementData = UISkillPlacementData;
            playerSaveData.PlayerHealthValue = characterEntity.HealthPoints.Value;
            playerSaveData.PlayerManaValue = characterEntity.ManaPoints.Value;
            playerSaveData.PlayerEnergyValue = characterEntity.EnergyPoints.Value;
            return playerSaveData;
        }
    }
}
