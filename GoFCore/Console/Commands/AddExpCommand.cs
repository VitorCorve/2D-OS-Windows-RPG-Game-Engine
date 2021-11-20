using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class AddExpCommand : IConsoleCommand
    {
        public AddExpCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Specify the value. Syntax: AddExp 100" };
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value)
        {
            Console.Model.Experience += value;
            Console.Model.CheckLevelUp();
            return new List<string> { value + " experience added to player" };
        }
    }
}
