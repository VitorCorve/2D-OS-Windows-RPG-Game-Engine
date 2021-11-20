using GameEngine.Console.Interfaces;
using System.Collections.Generic;

namespace GameEngine.Console.Commands
{
    public class ShowSkillListCommand : IConsoleCommand
    {
        public ShowSkillListCommand(IConsoleEngine console) => Console = console;
        public IConsoleEngine Console { get; set; }
        public List<string> Execute()
        {
            return new List<string>
            {
                "-----Skill-list----",
                "Fireball",
                "Heal",
                "MagicShield",
                "Polymorph",
                "Soulburn",
                "Backstab",
                "DissapearIntotheShadows",
                "FindtheWeakness",
                "Rend",
                "Stun",
                "CrushLegs",
                "DeepDefense",
                "LastManStanding",
                "PowerHit",
                "WideBlow",
                "--------------------",
            };
        }
        public List<string> Execute(string value) => new List<string> { "Incorrect value" };
        public List<string> Execute(int value) => new List<string> { "Incorrect value" };
    }
}
