using GameEngine.Player.DefenseResources;

namespace GameEngine.CombatEngine.Interfaces
{
    public interface IDefenseService
    {
        ISkill UsedSkill { get; }
        Block BlockChance { get; }
        Dodge DodgeChance { get; }
        Parry ParryChance { get; }
        Resist ResistChance { get; }
        bool DefenseCheck(ISkill type);
        double Chance();
    }
}
