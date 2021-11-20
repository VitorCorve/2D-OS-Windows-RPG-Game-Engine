using GameEngine.CombatEngine;
using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class SetEnduranceCommand : IConsoleCommand
    {
        public SetEnduranceCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Incorrect value" };
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value)
        {
            if (value < 1)
            {
                return new List<string> { "Value cannot be lower than 1" };
            }
            else
            {
                Console.Attributes.Endurance = value;
                var playerEntityConstructor = new PlayerEntityConstructor();
                Console.Entity = playerEntityConstructor.CreatePlayer(Console.Model, Console.Attributes, Console.Equipment.ToEquipmentValues());
                return new List<string> { "Endurance value setted to " + value };
            }

        }
    }
}
