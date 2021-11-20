using GameEngine.Console.Interfaces;
using GameEngine.Console.Services;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class LearnSkillCommand : IConsoleCommand
    {
        public LearnSkillCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Incorrect value" };
        public List<string> Execute(string value)
        {
            try
            {
                var skillToLearn = SkillBuilder.Build(value);
                Console.Skills.Skills.Add(skillToLearn);
                return new List<string> { $"Learned { skillToLearn.SkillName }" };
            }
            catch (System.Exception)
            {
                return new List<string> { "Skill not found" };
            }
        }
        public List<string> Execute(int value) => new List<string> { "Incorrect value" };
    }
}
