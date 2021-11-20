using GameEngine.CharacterCreationMaster.AvatarsNavigation;
using GameEngine.CharacterCreationMaster.Interfaces;
using GameEngine.CharacterCreationMaster.Interfaces.Services;
using GameEngine.Player;
using GameEngine.Player.ModelConditions;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.Services
{
    public class GetAvatarsData : IGetAvatarsData
    {
        public IAvatarPaths Collection { get; private set; }
        public List<PlayerAvatar> GetAvatarsList(SPECIALIZATION playerSpecialization, GENDER gender)
        {
            switch (gender)
            {
                case GENDER.Male:
                    return GetMaleAvatars(playerSpecialization);
                case GENDER.Female:
                    return GetFemaleAvatars(playerSpecialization);
            }
            return GetMaleAvatars(playerSpecialization);
        }
        private List<PlayerAvatar> GetMaleAvatars(SPECIALIZATION playerSpecialization)
        {
            var avatarsList = new List<PlayerAvatar>();

            switch (playerSpecialization)
            {
                case SPECIALIZATION.Mage:
                    Collection = new MageMaleAvatarPaths();
                    break;
                case SPECIALIZATION.Rogue:
                    Collection = new RogueMaleAvatarPaths();
                    break;
                default:
                    Collection = new WarriorMaleAvatarPaths();
                    break;
            }

            return CreateCollection();
        }
        private List<PlayerAvatar> GetFemaleAvatars(SPECIALIZATION playerSpecialization)
        {

            switch (playerSpecialization)
            {
                case SPECIALIZATION.Mage:
                    Collection = new MageFemaleAvatarPaths();
                    break;
                case SPECIALIZATION.Rogue:
                    Collection = new RogueFemaleAvatarPaths();
                    break;
                default:
                    Collection = new WarriorFemaleAvatarPaths();
                    break;
            }
            
            return CreateCollection();
        }
        private List<PlayerAvatar> CreateCollection()
        {
            var avatarsList = new List<PlayerAvatar>();

            foreach (var item in Collection.AvatarsData)
            {
                var avatarData = new PlayerAvatar();
                avatarData.ID = item.Key;
                avatarData.Path = item.Value;
                avatarsList.Add(avatarData);
            }
            foreach (var item in avatarsList)
            {
                foreach (var miniaturesItem in Collection.MiniatureData)
                {
                    if (item.ID == miniaturesItem.Key)
                    {
                        item.MiniaturePath = miniaturesItem.Value;
                    }
                }
            }
            return avatarsList;
        }
    }
}
