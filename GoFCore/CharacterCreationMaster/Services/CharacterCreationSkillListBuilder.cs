using GameEngine.CharacterCreationMaster.Interfaces.Services;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Services
{
    public class CharacterCreationSkillListBuilder : ICharacterCreationSkillListBuilder
    {
        public List<ISkill> Build(CharacterCreationData characterCreationData)
        {
            var playerModel = new PlayerModelData(characterCreationData);
            playerModel.Level = 30;
            var availableSkills = new AvailableSkillListBuilder(playerModel);
            playerModel.Level = 1;
            return availableSkills.SkillList;
        }
        public List<ISkill> Build(PlayerModelData playerModel)
        {
            playerModel.Level = 30;
            var availableSkills = new AvailableSkillListBuilder(playerModel);
            playerModel.Level = 1;
            return availableSkills.SkillList;
        }
    }
}
