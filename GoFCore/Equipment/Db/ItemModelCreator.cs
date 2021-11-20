using GameEngine.Equipment.Db.Items;

namespace GameEngine.Equipment.Db
{
    public class ItemModelCreator
    {
        public ItemModel CreateModelByID(int ID)
        {
            switch (ID)
            {
                case 0:
                    return new ItemID0().GetModel();
                case 1:
                    return new ItemID1().GetModel();
                case 2:
                    return new ItemID2().GetModel();                
                case 3:
                    return new ItemID3().GetModel();
                case 4:
                    return new ItemID4().GetModel();
                case 5:
                    return new ItemID5().GetModel();
                case 6:
                    return new ItemID6().GetModel();
                case 7:
                    return new ItemID7().GetModel();
                case 8:
                    return new ItemID8().GetModel();
                case 9:
                    return new ItemID9().GetModel();
                case 10:
                    return new ItemID10().GetModel();
                case 11:
                    return new ItemID11().GetModel();
                case 12:
                    return new ItemID12().GetModel();
                case 13:
                    return new ItemID13().GetModel();
                case 14:
                    return new ItemID14().GetModel();
                case 15:
                    return new ItemID15().GetModel();
                case 16:
                    return new ItemID16().GetModel();
                case 17:
                    return new ItemID17().GetModel();
                case 18:
                    return new ItemID18().GetModel();
                case 19:
                    return new ItemID19().GetModel();
                case 20:
                    return new ItemID20().GetModel();
                case 21:
                    return new ItemID21().GetModel();
                case 22:
                    return new ItemID22().GetModel();
                case 23:
                    return new ItemID23().GetModel();
                case 24:
                    return new ItemID24().GetModel();
                case 25:
                    return new ItemID25().GetModel();
                case 26:
                    return new ItemID26().GetModel();
                case 27:
                    return new ItemID27().GetModel();
                case 28:
                    return new ItemID28().GetModel();
                case 29:
                    return new ItemID29().GetModel();
                case 30:
                    return new ItemID30().GetModel();
                case 31:
                    return new ItemID31().GetModel();
                case 32:
                    return new ItemID32().GetModel();
                case 33:
                    return new ItemID33().GetModel();
                case 34:
                    return new ItemID34().GetModel();
                case 35:
                    return new ItemID35().GetModel();
                case 36:
                    return new ItemID36().GetModel();
                case 37:
                    return new ItemID37().GetModel();
                case 38:
                    return new ItemID38().GetModel();
                case 39:
                    return new ItemID39().GetModel();
                case 40:
                    return new ItemID40().GetModel();
                case 41:
                    return new ItemID41().GetModel();
                case 42:
                    return new ItemID42().GetModel();
                case 43:
                    return new ItemID43().GetModel();
                case 44:
                    return new ItemID44().GetModel();
                case 45:
                    return new ItemID45().GetModel();
                case 46:
                    return new ItemID46().GetModel();
                case 47:
                    return new ItemID47().GetModel();
                case 48:
                    return new ItemID48().GetModel();
                case 49:
                    return new ItemID49().GetModel();
                case 50:
                    return new ItemID50().GetModel();
                case 51:
                    return new ItemID51().GetModel();
                case 52:
                    return new ItemID52().GetModel();
                case 53:
                    return new ItemID53().GetModel();
                case 54:
                    return new ItemID54().GetModel();
                case 55:
                    return new ItemID55().GetModel();
                case 56:
                    return new ItemID56().GetModel();
                case 57:
                    return new ItemID57().GetModel();
                case 58:
                    return new ItemID58().GetModel();
                case 59:
                    return new ItemID59().GetModel();
                case 60:
                    return new ItemID60().GetModel();
                case 61:
                    return new ItemID61().GetModel();
                case 62:
                    return new ItemID62().GetModel();
                case 63:
                    return new ItemID63().GetModel();
                case 64:
                    return new ItemID64().GetModel();
                case 65:
                    return new ItemID65().GetModel();
                case 66:
                    return new ItemID66().GetModel();
                case 67:
                    return new ItemID67().GetModel();
                case 68:
                    return new ItemID68().GetModel();
                case 69:
                    return new ItemID69().GetModel();
                case 70:
                    return new ItemID70().GetModel();
                case 71:
                    return new ItemID71().GetModel();
                case 72:
                    return new ItemID72().GetModel();
                case 73:
                    return new ItemID73().GetModel();
                case 74:
                    return new ItemID74().GetModel();
                case 75:
                    return new ItemID75().GetModel();
                case 76:
                    return new ItemID76().GetModel();
                case 77:
                    return new ItemID77().GetModel();
                default:
                    throw new("Incorrect item ID");
            }
        }
    }
}
