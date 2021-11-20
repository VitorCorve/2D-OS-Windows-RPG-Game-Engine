using GameEngine.Equipment.Db.Items;

namespace GameEngine.Equipment.Db
{
    public class ItemAttributesCreator
    {
        public ItemAttributes CreateAttributesByID(int ID)
        {
            switch (ID)
            {
                case 0:
                    return new ItemID0().GetAttributes();
                case 1:
                    return new ItemID1().GetAttributes();
                case 2:
                    return new ItemID2().GetAttributes();
                case 3:
                    return new ItemID3().GetAttributes();
                case 4:
                    return new ItemID4().GetAttributes();
                case 5:
                    return new ItemID5().GetAttributes();
                case 6:
                    return new ItemID6().GetAttributes();
                case 7:
                    return new ItemID7().GetAttributes();
                case 8:
                    return new ItemID8().GetAttributes();
                case 9:
                    return new ItemID9().GetAttributes();
                case 10:
                    return new ItemID10().GetAttributes();
                case 11:
                    return new ItemID11().GetAttributes();
                case 12:
                    return new ItemID12().GetAttributes();
                case 13:
                    return new ItemID13().GetAttributes();
                case 14:
                    return new ItemID14().GetAttributes();
                case 15:
                    return new ItemID15().GetAttributes();
                case 16:
                    return new ItemID16().GetAttributes();
                case 17:
                    return new ItemID17().GetAttributes();
                case 18:
                    return new ItemID18().GetAttributes();
                case 19:
                    return new ItemID19().GetAttributes();
                case 20:
                    return new ItemID20().GetAttributes();
                case 21:
                    return new ItemID21().GetAttributes();
                case 22:
                    return new ItemID22().GetAttributes();
                case 23:
                    return new ItemID23().GetAttributes();
                case 24:
                    return new ItemID24().GetAttributes();
                case 25:
                    return new ItemID25().GetAttributes();
                case 26:
                    return new ItemID26().GetAttributes();
                case 27:
                    return new ItemID27().GetAttributes();
                case 28:
                    return new ItemID28().GetAttributes();
                case 29:
                    return new ItemID29().GetAttributes();
                case 30:
                    return new ItemID30().GetAttributes();
                case 31:
                    return new ItemID31().GetAttributes();
                case 32:
                    return new ItemID32().GetAttributes();
                case 33:
                    return new ItemID33().GetAttributes();
                case 34:
                    return new ItemID34().GetAttributes();
                case 35:
                    return new ItemID35().GetAttributes();
                case 36:
                    return new ItemID36().GetAttributes();
                case 37:
                    return new ItemID37().GetAttributes();
                case 38:
                    return new ItemID38().GetAttributes();
                case 39:
                    return new ItemID39().GetAttributes();
                case 40:
                    return new ItemID40().GetAttributes();
                case 41:
                    return new ItemID41().GetAttributes();
                case 42:
                    return new ItemID42().GetAttributes();
                case 43:
                    return new ItemID43().GetAttributes();
                case 44:
                    return new ItemID44().GetAttributes();
                case 45:
                    return new ItemID45().GetAttributes();
                case 46:
                    return new ItemID46().GetAttributes();
                case 47:
                    return new ItemID47().GetAttributes();
                case 48:
                    return new ItemID48().GetAttributes();
                case 49:
                    return new ItemID49().GetAttributes();
                case 50:
                    return new ItemID50().GetAttributes();
                case 51:
                    return new ItemID51().GetAttributes();
                case 52:
                    return new ItemID52().GetAttributes();
                case 53:
                    return new ItemID53().GetAttributes();
                case 54:
                    return new ItemID54().GetAttributes();
                case 55:
                    return new ItemID55().GetAttributes();
                case 56:
                    return new ItemID56().GetAttributes();
                case 57:
                    return new ItemID57().GetAttributes();
                case 58:
                    return new ItemID58().GetAttributes();
                case 59:
                    return new ItemID59().GetAttributes();
                case 60:
                    return new ItemID60().GetAttributes();
                case 61:
                    return new ItemID61().GetAttributes();
                case 62:
                    return new ItemID62().GetAttributes();
                case 63:
                    return new ItemID63().GetAttributes();
                case 64:
                    return new ItemID64().GetAttributes();
                case 65:
                    return new ItemID65().GetAttributes();
                case 66:
                    return new ItemID66().GetAttributes();
                case 67:
                    return new ItemID67().GetAttributes();
                case 68:
                    return new ItemID68().GetAttributes();
                case 69:
                    return new ItemID69().GetAttributes();
                case 70:
                    return new ItemID70().GetAttributes();
                case 71:
                    return new ItemID71().GetAttributes();
                case 72:
                    return new ItemID72().GetAttributes();
                case 73:
                    return new ItemID73().GetAttributes();
                case 74:
                    return new ItemID74().GetAttributes();
                case 75:
                    return new ItemID75().GetAttributes();
                case 76:
                    return new ItemID76().GetAttributes();
                case 77:
                    return new ItemID77().GetAttributes();
                default:
                    throw new("Incorrect item ID");
            }
        }
    }
}
