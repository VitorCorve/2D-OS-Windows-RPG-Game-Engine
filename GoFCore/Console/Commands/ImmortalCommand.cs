using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class ImmortalCommand : IConsoleCommand
    {
        public ImmortalCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value) => new List<string> { "Incorrect value" };
        public List<string> Execute()
        {
            if (Console.Entity.IsMortal.Value == false)
            {
                Console.Entity.Defense.IncomingDamageDivider = 0.0;
                Console.Entity.IsMortal.Value = true;
                return new List<string> { "Immortal mode activated" };
            }
            else
            {
                Console.Entity.Defense.IncomingDamageDivider = 1.0;
                Console.Entity.IsMortal.Value = false;
                return new List<string> { "Immortal mode deactivated" };
            }
        }
    }
}
