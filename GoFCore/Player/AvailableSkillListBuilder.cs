using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.Specializatons.Warrior;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Mage;
using System.Collections.Generic;

namespace GameEngine.Player
{
    public class AvailableSkillListBuilder
    {
        public List<ISkill> SkillList { get; private set; } = new();
        public List<ISkill> PlayerSkillList { get; private set; }
        public int PlayerLevel { get; private set; }
        public AvailableSkillListBuilder(PlayerModelData playerModel, List<ISkill> playerSkillList = null)
        {
            PlayerSkillList = playerSkillList ?? new List<ISkill>();

            PlayerLevel = playerModel.Level;

            switch (playerModel.Specialization)
            {
                case SPECIALIZATION.Warrior:
                    var warriorSkills = new GetWarriorSkills(PlayerLevel);
                    SkillList = warriorSkills.SkillList;
                    break;
                case SPECIALIZATION.Rogue:
                    var rogueSkills = new GetRogueSkills(PlayerLevel);
                    SkillList = rogueSkills.SkillList;
                    break;
                default:
                    var mageSkills = new GetMageSkills(PlayerLevel);
                    SkillList = mageSkills.SkillList;
                    break;
            }
            InitializeSkills();
        }
        private void InitializeSkills()
        {
            foreach (var item in SkillList)
            {
                if (item.SkillLevel < 1)
                    item.SkillLevel = 1;
            }
        }
        public void ValidateAvailableSkillList()
        {
            if (PlayerSkillList.Count == 0) return;

            foreach (var skill in PlayerSkillList)
            {
                foreach (var availableSkill in SkillList)
                {
                    if (availableSkill.SkillName == skill.SkillName)
                        availableSkill.SkillLevel = skill.SkillLevel;
                }
            }
        }
    }
}
