using GameEngine.CombatEngine;
using GameEngine.Equipment;
using GameEngine.Inventory;
using GameEngine.Player;
using GameEngine.Player.Abstract;
using System.Collections.Generic;

namespace GameEngine.Console.Interfaces
{
    public interface IConsoleEngine
    {
        List<string> Notification { get; }
        PlayerEntity Entity { get; set; }
        PlayerModelData Model { get; }
        PlayerInventoryItemsList Inventory { get; }
        WearedEquipment Equipment { get; }
        PlayerSkillList Skills { get; set; }
        IEntityAttributes Attributes { get; set; }
        public IConsoleCommand Command { get; }
        void RunCommand(string command);
    }
}
