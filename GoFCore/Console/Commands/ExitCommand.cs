using GameEngine.Console.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class ExitCommand : IConsoleCommand
    {
        public ExitCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute()
        {
            Environment.Exit(0);
            return new List<string> { "Closing application..." };
        }
        public List<string> Execute(string value)
        {
            Environment.Exit(0);
            return new List<string> { "Closing application..." };
        }
        public List<string> Execute(int value)
        {
            Environment.Exit(0);
            return new List<string> { "Closing application..." };
        }
    }
}
