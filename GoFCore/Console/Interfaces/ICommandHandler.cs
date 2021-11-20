using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Console.Interfaces
{
    public interface ICommandHandler
    {
        IConsoleEngine ConsoleEngine { get; }
        List<string> HandleCommand(string command);
    }
}
