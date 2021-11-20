using GameEngine.Console.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class ForgetAllSkillsCommand : IConsoleCommand
    {
        public ForgetAllSkillsCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute()
        {
            var removedSkillList = new List<string>();
            foreach (var item in Console.Skills.Skills)
            {
                removedSkillList.Add(item.SkillName + " removed from player");
            }
            Console.Skills = new PlayerSkillList();
            return removedSkillList;
        }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value) => new List<string> { "Incorrect value" };
    }
}
