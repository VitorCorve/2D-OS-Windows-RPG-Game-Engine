using GameEngine.Console.Interfaces;
using GameEngine.Equipment;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class AddItemCommand : IConsoleCommand
    {
        public AddItemCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute(int value)
        {
            try
            {
                var item = new ItemEntity(value);
                Console.Inventory.AddItem(item);
                return new List<string> { $"{item.Model.ItemName} with ID {value} added to player inventory" };
            }
            catch (System.Exception)
            {
                return new List<string> { $"Item with ID {value} didn't exist" };
            }
        }
        public List<string> Execute() => new List<string> { "Incorrect item ID" };
        public List<string> Execute(string value) => new List<string> { "Incorrect item ID" };
    }
}
