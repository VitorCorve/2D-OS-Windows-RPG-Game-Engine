using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Warrior;
using System.Collections.Generic;

namespace GameEngine.LevelUpMechanics.Services
{
    public class SkillLevelingListBuilder
    {
        public List<ISkill> GetDefaultSkillList(SPECIALIZATION playerSpecialization)
        {
            var skillList = new List<ISkill>();
            switch (playerSpecialization)
            {
                case SPECIALIZATION.Warrior:
                    var warriorSkills = new GetWarriorSkills(30);
                    skillList = warriorSkills.SkillList; 
                    break;
                case SPECIALIZATION.Rogue:
                    var rogueSkills = new GetRogueSkills(30);
                    skillList = rogueSkills.SkillList;
                    break;
                default:
                    var mageSkills = new GetMageSkills(30);
                    skillList = mageSkills.SkillList;
                    break;
            }
            return skillList;
        }
        public List<ISkill> ValidateLevels(List<ISkill> skillListTemplate, List<ISkill> validationSkillList)
        {
            foreach (var template in skillListTemplate)
            {
                foreach (var skill in validationSkillList)
                {
                    if (template.SkillName == skill.SkillName)
                    {
                        template.SkillLevel = skill.SkillLevel;
                    }
                }
            }
            return skillListTemplate;
        }
    }
}
