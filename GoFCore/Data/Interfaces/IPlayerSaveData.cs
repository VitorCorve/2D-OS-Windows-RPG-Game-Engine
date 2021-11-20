using GameEngine.CombatEngine;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Equipment;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.Data.Interfaces
{
    public interface IPlayerSaveData
    {
        ItemSerializationData ItemsInInventory { get; set; }
        ItemSerializationData ItemsOnCharacter { get; set; }
        PlayerSkillList PlayerSkills { get;  }
        int Level { get; }
        string Name { get; }
        SPECIALIZATION Specialization { get; }
        GENDER Gender { get; }
        int Money { get; }
        PlayerBiography Bio { get; }
        PlayerAvatarPath AvatarPath { get; }
        bool IsAutoSave { get; }
        int PlayerHealthValue { get; }
        int PlayerManaValue { get; }
        int PlayerEnergyValue { get; }
        int Experience { get; }
        int MaxExperience { get; }
        List<ISkill> UISkillPlacementData { get;  }
    }
}
