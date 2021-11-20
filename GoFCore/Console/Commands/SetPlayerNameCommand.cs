using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class SetPlayerNameCommand : IConsoleCommand
    {
        public SetPlayerNameCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Incorrect name" };
        public List<string> Execute(int value) => new List<string> { "Incorrect name" };
        public List<string> Execute(string value)
        {
            Console.Model.Name = (char.ToUpper(value[0]) + value.Substring(1));
            return new List<string> { $"Player name changed to {value}" };
        }
    }
}
