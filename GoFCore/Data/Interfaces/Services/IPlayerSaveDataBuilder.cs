using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Locations.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Data.Interfaces.Services
{
    public interface IPlayerSaveDataBuilder
    {
        PlayerSaveData Build(
            PlayerModelData playerModelData, 
            ILocation currentLocation, 
            PlayerInventoryItemsList inventoryItems, 
            WearedEquipment wearedItems, 
            PlayerSkillList skills, 
            IEntityAttributes playerAttributes, 
            List<ISkill> UISkillPlacementData,
            PlayerEntity characterEntity = null);
    }
}
