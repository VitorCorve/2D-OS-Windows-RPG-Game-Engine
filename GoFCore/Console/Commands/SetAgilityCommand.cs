﻿using GameEngine.CombatEngine;
using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class SetAgilityCommand : IConsoleCommand
    {
        public SetAgilityCommand(IConsoleEngine console) => Console = console;
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
                Console.Attributes.Agility = value;
                var playerEntityConstructor = new PlayerEntityConstructor();
                Console.Entity = playerEntityConstructor.CreatePlayer(Console.Model, Console.Attributes, Console.Equipment.ToEquipmentValues());
                return new List<string> { "Agility value setted to " + value };
            }

        }
    }
}
