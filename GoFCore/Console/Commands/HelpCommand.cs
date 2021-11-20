using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class HelpCommand : IConsoleCommand
    {
        public HelpCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute()
        {
            var commandsList = new List<string>
            {
                "\tAvailable commands list:",
                " ",
                "Help",
                "AddGold",
                "LevelUp",
                "AddExp",
                "AddSkillPoints",
                "AddAttributePoints",
                "AddPlayerLevel",
                "SetPlayerName",
                "AddItem",
                "LearnSkill",
                "ShowSkillList",
                "ForgetSkill",
                "ForgetAllSkills",
                "SetStamina",
                "SetStrenght",
                "SetEndurance",
                "SetIntellect",
                "SetAgility",
                "Immortal",
                "Exit",
            };
            return commandsList;
        }
        public List<string> Execute(int value) => new List<string> { "Help command type didn't recognized" };
        public List<string> Execute(string value) => new List<string> { "Help command type didn't recognized" };
    }
}
