using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class AddAttributePointsValueCommand : IConsoleCommand
    {
        public AddAttributePointsValueCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute()
        {
            Console.Model.PlayerConsumables.AttributePointsValue.Value++;
            return new List<string> { "Player attribute points: " + Console.Model.PlayerConsumables.AttributePointsValue.Value };
        }
        public List<string> Execute(int value)
        {
            Console.Model.PlayerConsumables.AttributePointsValue.Value += value;
            return new List<string> { "Player attribute points: " + Console.Model.PlayerConsumables.AttributePointsValue.Value };
        }
    }
}
