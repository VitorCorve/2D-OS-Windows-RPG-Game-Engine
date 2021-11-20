using GameEngine.Locations;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;

namespace GameEngine.Abstract
{
    public interface IPlayerModelData
    {
        string Name { get; }
        SPECIALIZATION Specialization { get; }
        GENDER Gender { get; }
        int Level { get; }
        LAND CurrentLand { get; }
        TOWN CurrentTown { get; }
        PLAYER_GRADE PlayerGrade { get; }
        PlayerBiography Bio { get; }
        int Experience { get; }
        int MaxExperience { get; }
        void LevelUp();
    }
}
