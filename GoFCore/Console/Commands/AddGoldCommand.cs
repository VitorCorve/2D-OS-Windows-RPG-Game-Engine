using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class AddGoldCommand : IConsoleCommand
    {
        public AddGoldCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Incorrect value" };
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value)
        {
            Console.Model.PlayerConsumables.IncreaseValue(value * 10000);
            return new List<string> { $"{ value } gold added to player inventory" };
        }
    }
}
