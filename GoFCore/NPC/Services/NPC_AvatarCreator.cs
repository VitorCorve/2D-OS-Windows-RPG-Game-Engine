using GameEngine.NPC.Specializations;
using GameEngine.Player;
using System;

namespace GameEngine.NPC.Services
{
    public class NPC_AvatarCreator
    {
        public static PlayerAvatarPath Create(NPC_NAME npcName)
        {
            var playerAvatar = new PlayerAvatarPath();
            switch (npcName)
            {
                // animals
                case NPC_NAME.Bear:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\bear.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\bear.png";
                    return playerAvatar;
                case NPC_NAME.Boar:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\boar.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\boar.png";
                    return playerAvatar;
                case NPC_NAME.Rat:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\rat.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\rat.png";
                    return playerAvatar;
                case NPC_NAME.Wolf:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\wolf.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\animals\\wolf.png";
                    return playerAvatar;
                // dragons
                case NPC_NAME.Amphiptere:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\amphiptere.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\amphiptere.png";
                    return playerAvatar;
                case NPC_NAME.Earthreaper:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\earthreaper.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\earthreaper.png";
                    return playerAvatar;
                case NPC_NAME.Knucker:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\knucker.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\knucker.png";
                    return playerAvatar;
                case NPC_NAME.Lindworm:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\lindworm.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\lindworm.png";
                    return playerAvatar;
                case NPC_NAME.Wyvern:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\wyvern.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\dragons\\wyvern.png";
                    return playerAvatar;
                // humans
                case NPC_NAME.Assassin:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Assassin.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Assassin.png";
                    return playerAvatar;
                case NPC_NAME.Bandit:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Bandit.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Bandit.png";
                    return playerAvatar;
                case NPC_NAME.Mercenary:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Mercenary.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Mercenary.png";
                    return playerAvatar;
                case NPC_NAME.Thug:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Thug.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Thug.png";
                    return playerAvatar;
                case NPC_NAME.Scavenger:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Scavenger.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\humans\\Scavenger.png";
                    return playerAvatar;
                // undeads
                case NPC_NAME.Ancient_Warrior:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\ancient_warrior.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\Ancient_warrior.png";
                    return playerAvatar;
                case NPC_NAME.Inquisitor:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\inquisitor.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\inquisitor.png";
                    return playerAvatar;
                case NPC_NAME.Necrolord:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\necrolord.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\necrolord.png";
                    return playerAvatar;
                case NPC_NAME.Skeleton:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\skeleton.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\skeleton.png";
                    return playerAvatar;
                case NPC_NAME.Undead_Sorcerer:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\undead_sorcerer.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\undeads\\undead_sorcerer.png";
                    return playerAvatar;
                // vampires
                case NPC_NAME.Ghoul:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\ghoul.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\ghoul.png";
                    return playerAvatar;
                case NPC_NAME.Nightlord:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\nightlord.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\nightlord.png";
                    return playerAvatar;
                case NPC_NAME.Nosferatu:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\nosferatu.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\nosferatu.png";
                    return playerAvatar;
                case NPC_NAME.Servant:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\servant.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\servant.png";
                    return playerAvatar;
                case NPC_NAME.Vampire:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\vampire.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\vampires\\vampire.png";
                    return playerAvatar;
                // werewolfs
                case NPC_NAME.Cursed_Traveler:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\cursed_traveler.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\cursed_traveler.png";
                    return playerAvatar;
                case NPC_NAME.Hearthbreaker:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\hearthbreaker.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\hearthbreaker.png";
                    return playerAvatar;
                case NPC_NAME.Moonwalker:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\moonwalker.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\moonwalker.png";
                    return playerAvatar;
                case NPC_NAME.Nightmare:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\nightmare.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\nightmare.png";
                    return playerAvatar;
                case NPC_NAME.Werewolf:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\werewolf.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\werewolfes\\werewolf.png";
                    return playerAvatar;
                case NPC_NAME.Trader:
                    break;
                case NPC_NAME.Blacksmith:
                    break;
                default:
                    playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\bandits\\2.jpg";
                    playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\bandits\\2.png";
                    return playerAvatar;
            }

            if (playerAvatar.Path is null)
            {
                playerAvatar.Path = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\bandits\\1.jpg";
                playerAvatar.MiniaturePath = Environment.CurrentDirectory + "\\Data\\Images\\Enemies\\bandits\\1.png";
                return playerAvatar;
            }
            return null;
        }
    }
}
