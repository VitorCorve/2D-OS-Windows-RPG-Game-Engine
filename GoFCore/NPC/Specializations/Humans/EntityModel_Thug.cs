using GameEngine.NPC.Interfaces.SpecializationArchetypes;
using GameEngine.Player;

namespace GameEngine.NPC.Specializations.Humans
{
    public class EntityModel_Thug : IHuman
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int WeaponDamageValue { get; set; }
        public int ArmorValue { get; set; }
        public NPC_TYPE NPC_Type { get; private set; }
        public NPC_NAME Name { get; private set; }
        public EntityModel_Thug()
        {
            NPC_Type = NPC_TYPE.Human;
            Name = NPC_NAME.Thug;

            Strength = 7;
            Stamina = 6;
            Intellect = 2;
            Agility = 3;
            Endurance = 3;
        }
    }
}
