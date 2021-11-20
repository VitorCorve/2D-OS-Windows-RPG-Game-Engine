using GameEngine.Data.Interfaces.Services;

namespace GameEngine.Data.Services
{
    public class GameLoadToGameSaveDataConvertationService : IConvertLoadToSaveFormatService
    {
        public PlayerSaveData Covert(PlayerLoadData playerData)
        {
            var saveDataFormat = new PlayerSaveData();

            saveDataFormat.ItemsOnCharacter.PrepareToSerialize(playerData.Equipment.ItemsList);
            saveDataFormat.ItemsInInventory.PrepareToSerialize(playerData.Inventory.ItemsInInventory);
            saveDataFormat.PlayerSkills = playerData.ListOfSkills;
            saveDataFormat.AvailableSkillPoints = playerData.PlayerModel.PlayerConsumables.SkillPointsValue.Value;
            saveDataFormat.Level = playerData.PlayerModel.Level;
            saveDataFormat.Name = playerData.PlayerModel.Name;
            saveDataFormat.Specialization = playerData.PlayerModel.Specialization;
            saveDataFormat.Gender = playerData.PlayerModel.Gender;
            saveDataFormat.Money = playerData.PlayerModel.PlayerConsumables.AbsoluteMoneyValue;
            saveDataFormat.Bio = playerData.PlayerModel.Bio;
            saveDataFormat.AvatarPath = playerData.PlayerModel.AvatarPath;

            return saveDataFormat;
        }
    }
}
