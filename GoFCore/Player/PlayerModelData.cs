using GameEngine.Abstract;
using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.Data;
using GameEngine.Locations;
using GameEngine.Player.ModelConditions;

namespace GameEngine.Player
{
    public class PlayerModelData : IPlayerModelData
    {
        public delegate void Notification();
        public event Notification NewLevelGainded;
        public string Name { get;  set; }
        public SPECIALIZATION Specialization { get; private set; }
        public GENDER Gender { get; set; }
        private int _Level;
        public int Level { get => _Level; set { _Level = value; CheckPlayerGrade(); } }
        public LAND CurrentLand { get; set; }
        public TOWN CurrentTown { get; set; }
        public int Experience { get; set; }
        public int MaxExperience { get; set; }
        public PLAYER_GRADE PlayerGrade { get; set; }
        public PlayerBiography Bio { get; set; }
        public PlayerAvatarPath AvatarPath { get; set; }
        public PlayerConsumablesData PlayerConsumables { get; set; }
        public PlayerModelData(PlayerSpecializationAttributes player, GENDER gender, string name, int level, int money)
        {
            PlayerConsumables = new PlayerConsumablesData(money);
            Name = name;
            Specialization = player.Specialization;
            Gender = gender;
            Level = level;
            MaxExperience = 36 + (Level * 6);
        }
        public PlayerModelData(SPECIALIZATION playerSpecialization, GENDER gender, string name, int level, int money)
        {
            PlayerConsumables = new PlayerConsumablesData(money);
            Name = name;
            Specialization = playerSpecialization;
            Gender = gender;
            Level = level;
            MaxExperience = 36 + (Level * 6);
        }
        public PlayerModelData(ICharacterCreationData characterCreationData)
        {
            Bio = characterCreationData.Bio;
            PlayerConsumables = new PlayerConsumablesData(0);
            Name = characterCreationData.Name;
            AvatarPath = characterCreationData.AvatarPath;
            Specialization = characterCreationData.CharacterSpecialization;
            Gender = characterCreationData.Gender;
            Level = 1;
            MaxExperience = 36 + (Level * 6);
        }
        private void CheckPlayerGrade()
        {
            switch (Level)
            {
                case < 6:
                    PlayerGrade = PLAYER_GRADE.Novice;
                    return;
                case < 11:
                    PlayerGrade=  PLAYER_GRADE.Advanced;
                    return;
                case < 16:
                    PlayerGrade = PLAYER_GRADE.Adept;
                    return;
                case < 21:
                    PlayerGrade = PLAYER_GRADE.Expert;
                    return;
                case < 26:
                    PlayerGrade = PLAYER_GRADE.Master;
                    return;
                case < 31:
                    PlayerGrade = PLAYER_GRADE.Legend;
                    return;
                default:
                    PlayerGrade=  PLAYER_GRADE.Legend;
                    return;
            }
        }
        public void CheckLevelUp()
        {
            while (Experience > MaxExperience)
            {
                Experience -= MaxExperience;
                LevelUp();
            }
        }
        public PlayerModelData(PlayerSaveData playerSaveData)
        {
            Level = playerSaveData.Level;
            Experience = playerSaveData.Experience;
            PlayerConsumables = new PlayerConsumablesData(playerSaveData.Money);
            PlayerConsumables.AttributePointsValue.Value = playerSaveData.AvailableAttributePoints;
            PlayerConsumables.SkillPointsValue.Value = playerSaveData.AvailableSkillPoints;
            Name = playerSaveData.Name;
            Specialization = playerSaveData.Specialization;
            Gender = playerSaveData.Gender;
            MaxExperience = playerSaveData.MaxExperience;
            CurrentLand = playerSaveData.CurrentLand;
            CurrentTown = playerSaveData.CurrentTown;
            Bio = playerSaveData.Bio;
            AvatarPath = playerSaveData.AvatarPath;
        }
        public void LevelUp()
        {
            Level++;
            MaxExperience = 36 + (Level * 6);
            PlayerConsumables.SkillPointsValue.Value++;
            PlayerConsumables.AttributePointsValue.Value++;
            NewLevelGainded?.Invoke();
        }
    }
}
