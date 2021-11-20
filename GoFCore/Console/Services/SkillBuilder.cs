using GameEngine.CombatEngine.Interfaces;
using GameEngine.SpecializationMechanics.Mage.Skills;
using GameEngine.SpecializationMechanics.Rogue.Skills;
using GameEngine.SpecializationMechanics.Warrior.Skills;
using System;

namespace GameEngine.Console.Services
{
    public class SkillBuilder
    {
        public static ISkill Build(string skillName)
        {
            switch (skillName)
            {
                case "fireball":
                    return new Fireball() { SkillLevel = 1};
                case "heal":
                    return new Heal() { SkillLevel = 1 };
                case "magicshield":
                    return new MagicShield() { SkillLevel = 1 };
                case "polymorph":
                    return new Polymorph() { SkillLevel = 1 };
                case "soulburn":
                    return new Soulburn() { SkillLevel = 1 };
                case "backstab":
                    return new Backstab() { SkillLevel = 1 };
                case "dissapearintotheshadows":
                    return new DissapearIntoTheShadows() { SkillLevel = 1 };
                case "findtheweakness":
                    return new FindTheWeakness() { SkillLevel = 1 };
                case "rend":
                    return new Rend() { SkillLevel = 1 };
                case "stun":
                    return new Stun() { SkillLevel = 1 };
                case "crushlegs":
                    return new CrushLegs() { SkillLevel = 1 };
                case "deepdefense":
                    return new DeepDefense() { SkillLevel = 1 };
                case "lastmanstanding":
                    return new LastManStanding() { SkillLevel = 1 };
                case "powerhit":
                    return new PowerHit() { SkillLevel = 1 };
                case "wideblow":
                    return new WideBlow() { SkillLevel = 1 };
                default:
                    throw new Exception($"{skillName} not found");
            }
        }
    }
}
