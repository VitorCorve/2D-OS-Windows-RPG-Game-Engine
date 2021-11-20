using GameEngine.CombatEngine.Actions;
using GameEngine.CombatEngine.ActionTypes;
using GameEngine.CombatEngine.Interfaces;
using GameEngine.Player.DefenseResources;
using System;


namespace GameEngine.CombatEngine
{
    public class DefenseService : IDefenseService
    {
        public delegate void NotifyMaster(ACTION_TYPE actionType, string message, ISkill skill);
        public event NotifyMaster Log;
        public ISkill UsedSkill { get; set; }
        public Block BlockChance { get; private set; }
        public Dodge DodgeChance { get; private set; } = new Dodge();
        public Parry ParryChance { get; private set; }
        public Resist ResistChance { get; private set; }
        public DefenseService(PlayerEntity player)
        {
            BlockChance = player.BlockChance;
            DodgeChance = player.DodgeChance;
            ParryChance = player.ParryChance;
            ResistChance = player.ResistChance;
        }

        public bool DefenseCheck(ISkill skill)
        {
            UsedSkill = skill;
            switch (skill.Type)
            {
                case Melee:
                    return
                        TryMeleeDefense();
                case Magic:
                    return
                        TryMagicDefense();
                default:
                    break;
            }
            return false;
        }

        public double Chance()
        {
            var random = new Random();
            double randomValue = random.Next(0, 100);
            return randomValue;
        }

        private bool TryMeleeDefense()
        {
            double chance = Chance();

            if (chance < BlockChance.Value)
            {
                Log(ACTION_TYPE.Block, "blocked attack", UsedSkill);
                return false;
            }
                

            if (chance < DodgeChance.Value)
            {
                Log(ACTION_TYPE.Dodge, "dodged attack", UsedSkill);
                return false;
            }
                

            if (chance < ParryChance.Value)
            {
                Log(ACTION_TYPE.Parry, "parried attack", UsedSkill);
                return false;
            }
            return true;
        }

        private bool TryMagicDefense()
        {
            if (Chance() < ResistChance.Value)
            {
                Log(ACTION_TYPE.Resist, "resisted attack", UsedSkill);
                return false;
            }
            return true;
        }
    }
}
