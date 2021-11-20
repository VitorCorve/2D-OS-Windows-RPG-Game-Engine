using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Interfaces.Services
{
    public interface ICharacterCreationSkillListBuilder
    {
        List<ISkill> Build(CharacterCreationData characterCreationData);
        List<ISkill> Build(PlayerModelData playerModel);
    }
}
