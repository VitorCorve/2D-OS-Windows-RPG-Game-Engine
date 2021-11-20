using GameEngine.Console.Commands;
using GameEngine.Console.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.Console.Services
{
    public class CommandHandler : ICommandHandler
    {
        public IConsoleEngine ConsoleEngine { get; private set; }
        public IConsoleCommand LevelUpCommand { get; private set; }
        public IConsoleCommand SetPlayerLevelCommand { get; private set; }
        public IConsoleCommand AddGoldCommand { get; private set; }
        public IConsoleCommand HelpCommand { get; private set; }
        public IConsoleCommand SetPlayerNameCommand { get; private set; }
        public IConsoleCommand AddItemCommand { get; private set; }
        public IConsoleCommand ExitCommand { get; private set; }
        public IConsoleCommand LearnSkillCommand { get; private set; }
        public IConsoleCommand ShowSkillListCommand { get; private set; }
        public IConsoleCommand ForgetSkillCommand { get; private set; }
        public IConsoleCommand ForgetAllSkillsCommand { get; private set; }
        public IConsoleCommand SetStaminaCommand { get; private set; }
        public IConsoleCommand SetStrengthCommand { get; private set; }
        public IConsoleCommand SetEnduranceCommand { get; private set; }
        public IConsoleCommand SetIntellectCommand { get; private set; }
        public IConsoleCommand SetAgilityCommand { get; private set; }
        public IConsoleCommand AddSkillPointsValueCommand { get; private set; }
        public IConsoleCommand AddAttributePointsValueCommand { get; private set; }
        public IConsoleCommand ImmortalCommand { get; private set; }
        public IConsoleCommand AddExpCommand { get; private set; }
        public CommandHandler(ConsoleEngine consoleEngine)
        {
            ConsoleEngine = consoleEngine;
            LevelUpCommand = new LevelUpCommand(consoleEngine);
            SetPlayerLevelCommand = new AddPlayerLevelCommand(consoleEngine);
            AddGoldCommand = new AddGoldCommand(consoleEngine);
            HelpCommand = new HelpCommand(consoleEngine);
            SetPlayerNameCommand = new SetPlayerNameCommand(consoleEngine);
            AddItemCommand = new AddItemCommand(consoleEngine);
            ExitCommand = new ExitCommand(consoleEngine);
            LearnSkillCommand = new LearnSkillCommand(consoleEngine);
            ShowSkillListCommand = new ShowSkillListCommand(consoleEngine);
            ForgetSkillCommand = new ForgetSkillCommand(consoleEngine);
            ForgetAllSkillsCommand = new ForgetAllSkillsCommand(consoleEngine);
            SetStaminaCommand = new SetStaminaCommand(consoleEngine);
            SetStrengthCommand = new SetStrengthCommand(consoleEngine);
            SetEnduranceCommand = new SetEnduranceCommand(consoleEngine);
            SetIntellectCommand = new SetIntellectCommand(consoleEngine);
            SetAgilityCommand = new SetAgilityCommand(consoleEngine);
            AddSkillPointsValueCommand = new AddSkillPointsValueCommand(consoleEngine);
            AddAttributePointsValueCommand = new AddAttributePointsValueCommand(consoleEngine);
            ImmortalCommand = new ImmortalCommand(consoleEngine);
            AddExpCommand = new AddExpCommand(consoleEngine);
        }
        public List<string> HandleCommand(string command)
        {
            var recognizedCommand = Recognize(ConvertString(command));
            string body = recognizedCommand[0];

            if (recognizedCommand.Length > 1)
            {
                string parametr = recognizedCommand[1];
                return SecondLevelCommand(body, parametr);
            }
            else
            {
                return FirstLevelCommand(body);
            }
        }
        private List<string> FirstLevelCommand(string command)
        {
            switch (command)
            {
                case "help":
                    return HelpCommand.Execute();
                case "levelup":
                    return LevelUpCommand.Execute();
                case "exit":
                    return ExitCommand.Execute();
                case "showskilllist":
                    return ShowSkillListCommand.Execute();
                case "forgetallskills":
                    return ForgetAllSkillsCommand.Execute();
                case "addskillpoints":
                    return AddSkillPointsValueCommand.Execute();
                case "addattributepoints":
                    return AddAttributePointsValueCommand.Execute();
                case "immortal":
                    return ImmortalCommand.Execute();
                default:
                    break;
            }
            var result = new List<string>();
            result.Add($"Command {command} not recognized. Type \"Help\" to see commands list");
            return result;
        }
        private List<string> SecondLevelCommand(string command, string value)
        {
            switch (command)
            {
                case "addplayerlevel":
                    return SetPlayerLevelCommand.Execute(GetTypeOf(value));
                case "addgold":
                    return AddGoldCommand.Execute(GetTypeOf(value));
                case "additem":
                    return AddItemCommand.Execute(GetTypeOf(value));
                case "setplayername":
                    return SetPlayerNameCommand.Execute(GetTypeOf(value));
                case "learnskill":
                    return LearnSkillCommand.Execute(GetTypeOf(value));
                case "forgetskill":
                    return ForgetSkillCommand.Execute(GetTypeOf(value));
                case "setstamina":
                    return SetStaminaCommand.Execute(GetTypeOf(value));
                case "setstrength":
                    return SetStrengthCommand.Execute(GetTypeOf(value));
                case "setendurance":
                    return SetEnduranceCommand.Execute(GetTypeOf(value));
                case "setintellect":
                    return SetIntellectCommand.Execute(GetTypeOf(value));
                case "setagility":
                    return SetAgilityCommand.Execute(GetTypeOf(value));
                case "addskillpoints":
                    return AddSkillPointsValueCommand.Execute(GetTypeOf(value));
                case "addattributepoints":
                    return AddAttributePointsValueCommand.Execute(GetTypeOf(value));
                case "addexp":
                    return AddExpCommand.Execute(GetTypeOf(value));
                default:
                    break;
            }
            var result = new List<string>();
            result.Add($"Command {command} not recognized. Type \"Help\" to see commands list");
            return result;
        }
        private string ConvertString(string text) => text.ToLower();
        private string[] Recognize(string text) => text.Split(" ");
        private bool IsNumeric(string value) => int.TryParse(value, out int n);
        private dynamic GetTypeOf(string parametr)
        {
            if (IsNumeric(parametr)) return Convert.ToInt32(parametr);
            else return parametr;
        }
    }
}
