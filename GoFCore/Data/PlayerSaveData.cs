using GameEngine.CombatEngine.Interfaces;
using GameEngine.Data.Interfaces;
using GameEngine.Equipment;
using GameEngine.Locations;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.Data
{
    public class PlayerSaveData : IPlayerSaveData
    {
        public IEntityAttributes PlayerAttributes { get; set; }
        public ItemSerializationData ItemsInInventory { get; set; } = new();
        public ItemSerializationData ItemsOnCharacter{ get; set; } = new();
        public PlayerSkillList PlayerSkills { get; set; }
        public int AvailableSkillPoints { get; set; }
        public int AvailableAttributePoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public SPECIALIZATION Specialization { get; set; }
        public GENDER Gender { get; set; }
        public int Money { get; set; }
        public PlayerBiography Bio { get; set; }
        public PlayerAvatarPath AvatarPath { get; set; }
        public string Date { get; set; }
        public string DateShort { get; set; }
        public int Experience { get; set; }
        public int MaxExperience { get; set; }
        public LAND CurrentLand { get; set; }
        public TOWN CurrentTown { get; set; }
        public bool IsAutoSave { get; set; }
        public int PlayerHealthValue { get; set; }
        public int PlayerManaValue { get; set; }
        public int PlayerEnergyValue { get; set; }
        public List<ISkill> UISkillPlacementData { get; set; }
    }
}
