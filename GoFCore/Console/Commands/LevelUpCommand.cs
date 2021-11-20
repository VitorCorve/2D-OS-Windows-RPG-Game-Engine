using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class LevelUpCommand : IConsoleCommand
    {
        public LevelUpCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute()
        {
            Console.Model.LevelUp();
            return new List<string>
            {
                "Player level: " + Console.Model.Level,
                "Max experience setted to " + Console.Model.MaxExperience,
                "1 Attribute point added",
                "1 Skill point added",
                "",
                "\tCharacter:",
                "Name: " + Console.Model.Name,
                "Level:" + Console.Model.Level,
                "Gender:" + Console.Model.Gender,
                "Specialization: " + Console.Model.Specialization,
                "Location " + Console.Model.CurrentTown,
                "Stamina " + Console.Attributes.Stamina,
                "Strength " + Console.Attributes.Strength,
                "Endurance " + Console.Attributes.Endurance,
                "Intellect " + Console.Attributes.Intellect,
                "Agility " + Console.Attributes.Agility,
                "",
            };
        }
        public List<string> Execute(int value) => new List<string> { "AddPlayerLevelCommand didn't supports values" };
    }
}
