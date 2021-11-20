
using System.Collections.Generic;

namespace GameEngine.Console.Interfaces
{
    public interface IConsoleCommand
    {
        IConsoleEngine Console { get; }
        List<string> Execute();
        List<string> Execute(int value);
        List<string> Execute(string value);
    }
}
