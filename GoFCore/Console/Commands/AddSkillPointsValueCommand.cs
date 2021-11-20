using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class AddSkillPointsValueCommand : IConsoleCommand
    {
        public AddSkillPointsValueCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute()
        {
            Console.Model.PlayerConsumables.SkillPointsValue.Value++;
            return new List<string> { "Player skill points: " + Console.Model.PlayerConsumables.SkillPointsValue.Value };
        }
        public List<string> Execute(int value)
        {
            Console.Model.PlayerConsumables.SkillPointsValue.Value += value;
            return new List<string> { "Player skill points: " + Console.Model.PlayerConsumables.SkillPointsValue.Value };
        }
    }
}
