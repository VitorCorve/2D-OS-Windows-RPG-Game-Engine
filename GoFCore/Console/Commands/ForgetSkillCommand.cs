using GameEngine.CombatEngine.Interfaces;
using GameEngine.Console.Interfaces;
using GameEngine.Console.Services;
using GameEngine.SpecializationMechanics.UniversalSkills;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class ForgetSkillCommand : IConsoleCommand
    {
        private ISkill SkillToRemove;
        public ForgetSkillCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute() => new List<string> { "Incorrect value" };
        public List<string> Execute(string value)
        {
            try
            {
                var skillToLearn = SkillBuilder.Build(value);
                foreach (var item in Console.Skills.Skills)
                {
                    if (item.SkillName == skillToLearn.SkillName)
                    {
                        SkillToRemove = item;
                    }
                }
                RemoveSkill(SkillToRemove);
                return new List<string> { $"{ skillToLearn.SkillName } removed from player" };
            }
            catch (System.Exception)
            {
                return new List<string> { "Skill not found" };
            }
        }
        public List<string> Execute(int value) => new List<string> { "Incorrect value" };
        private void RemoveSkill(ISkill skill)
        {
            Console.Skills.Skills.Remove(skill);
            SkillToRemove = null;
        }
    }
}
