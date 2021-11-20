using GameEngine.Abstract;
using GameEngine.Data.Interfaces;
using GameEngine.Equipment;
using GameEngine.Equipment.Resource;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Warrior;
using GameEngine.Specializatons;
using System.Collections.Generic;

namespace GameEngine.Data
{
    public class PlayerLoadData : IPlayerLoadData
    {
        public WearedEquipment Equipment { get; set; }
        public PlayerInventoryItemsList Inventory { get; set; }
        public PlayerSkillList ListOfSkills { get; set; }
        public PlayerModelData PlayerModel { get; set; }
        public PlayerSpecializationAttributes Specialization { get; set; }
        public IEntityAttributes SpecializationAttributes { get; set; }
        public PlayerLoadData(PlayerSaveData playerSaveData)
        {
            var itemsInInventoryData = playerSaveData.ItemsInInventory;
            var itemsOnCharacterData = playerSaveData.ItemsOnCharacter;

            if (itemsInInventoryData.ID != null)
                Inventory = new PlayerInventoryItemsList(itemsInInventoryData.ConvertToInventoryItemsList());
            if (itemsOnCharacterData.ID != null)
                Equipment = new WearedEquipment(itemsOnCharacterData.ConvertToInventoryItemsList());

            ListOfSkills = playerSaveData.PlayerSkills ?? new PlayerSkillList();

            SpecializationAttributes = playerSaveData.PlayerAttributes;

            PlayerModel = new PlayerModelData(Specialization, playerSaveData.Gender, playerSaveData.Name, playerSaveData.Level, playerSaveData.Money);
            PlayerModel.PlayerConsumables.SkillPointsValue.Value = playerSaveData.AvailableSkillPoints;
            PlayerModel.Bio = playerSaveData.Bio;
            PlayerModel.AvatarPath = playerSaveData.AvatarPath;
        }
    }
}
