using GameEngine.NPC.Interfaces;
using GameEngine.Player;

namespace GameEngine.Experience
{
    public class ExperienceMaster
    {
        public int Value { get; set; }
        public PlayerModelData AddExperience(PlayerModelData playerModel , INPC_ModelData npcModelData)
        {
            Value = 0;
            Value = npcModelData.Level * 2;
            switch (npcModelData.Level)
            {
                case < 5:
                    Value = npcModelData.Level * 2;
                    break;
                case < 10:
                    Value = npcModelData.Level;
                    break;
                case < 15:
                    Value = npcModelData.Level / 2;
                    break;
                case < 20:
                    Value = npcModelData.Level / 4;
                    break;
                case < 40:
                    Value = npcModelData.Level / 8;
                    break;
                default:
                    break;
            }
            playerModel.Experience += Value;
            playerModel.CheckLevelUp();
            return playerModel;
        }
    }
}
