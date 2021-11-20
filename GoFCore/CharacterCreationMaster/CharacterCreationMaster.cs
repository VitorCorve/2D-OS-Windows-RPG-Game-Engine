using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.CharacterCreationMaster.Services;
using GameEngine.Player;
using GameEngine.Player.Specializatons.Mage;
using GameEngine.Player.Specializatons.Rogue;
using GameEngine.Player.Specializatons.Warrior;

namespace GameEngine.CharacterCreationMaster
{
    public class CharacterCreationMaster : ICharacterCreationMaster
    {
        public CharacterCreationData CharacterData { get; private set; }
        public CharacterCreationSkillListBuilder SkillBuilder { get; private set; }
        public CharacterCreationMaster()
        {
            CharacterData = new CharacterCreationData();
            SkillBuilder = new CharacterCreationSkillListBuilder();
            CharacterData.CharacterAttributes = new EntityModel_Warrior();
            CharacterData.AvailableSkills = SkillBuilder.Build(CharacterData);
            CharacterData.CharacterSpecialization = SPECIALIZATION.Warrior;
            SelectAttributeDescription(0);
        }
        public void SelectSpecialization(int index)
        {
            var avatarsData = new GetAvatarsData();
            switch (index)
            {
                case 1:
                    CharacterData.CharacterSpecialization = SPECIALIZATION.Mage;
                    CharacterData.CharacterAttributes = new EntityModel_Mage();
                    CharacterData.PlayerAvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
                    CharacterData.AvailableSkills = SkillBuilder.Build(CharacterData);
                    return;
                case 2:
                    CharacterData.CharacterSpecialization = SPECIALIZATION.Rogue;
                    CharacterData.CharacterAttributes = new EntityModel_Rogue();
                    CharacterData.PlayerAvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
                    CharacterData.AvailableSkills = SkillBuilder.Build(CharacterData);
                    return;
                default:
                    CharacterData.CharacterSpecialization = SPECIALIZATION.Warrior;
                    CharacterData.CharacterAttributes = new EntityModel_Warrior();
                    CharacterData.PlayerAvatarsList = avatarsData.GetAvatarsList(CharacterData.CharacterSpecialization, CharacterData.Gender);
                    CharacterData.AvailableSkills = SkillBuilder.Build(CharacterData);
                    return;
            }
        }
        public void SelectGender(int index)
        {
            if (index == 0)
                CharacterData.Gender = GENDER.Male;
            else
                CharacterData.Gender = GENDER.Female;
        }
        public void SelectAttributeDescription(int index)
        {
            int count = 0;
            foreach (var item in CharacterData.AttributesDescriptionList)
            {
                if (count == index)
                {
                    CharacterData.AttributeDescription = item;
                    return;
                }
                else
                    count++;
            }
        }
    }
}
