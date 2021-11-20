using GameEngine.CombatEngine;
using GameEngine.Console.Interfaces;
using GameEngine.Console.Services;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Console
{
    public class ConsoleEngine : IConsoleEngine
    {
        public List<string> Notification { get; set; }
        public PlayerEntity Entity { get; set; }
        public PlayerModelData Model { get; set; }
        public PlayerInventoryItemsList Inventory { get; set; }
        public WearedEquipment Equipment { get; set; }
        public PlayerSkillList Skills { get; set; }
        public IConsoleCommand Command { get; set; }
        public ICommandHandler CommandHandler { get; set; }
        public IEntityAttributes Attributes { get; set; }
        public ConsoleEngine(PlayerEntity entity, PlayerModelData model, PlayerInventoryItemsList inventory, WearedEquipment equipment, PlayerSkillList skills, IEntityAttributes attributes)
        {
            Entity = entity;
            Model = model;
            Inventory = inventory;
            Equipment = equipment;
            Skills = skills;
            Attributes = attributes;
            CommandHandler = new CommandHandler(this);
        }
        public void RunCommand(string command) => Notification = CommandHandler.HandleCommand(command);
    }
}
