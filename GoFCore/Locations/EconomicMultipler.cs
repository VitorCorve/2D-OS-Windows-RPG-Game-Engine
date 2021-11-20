using GameEngine.Locations.Interfaces;

namespace GameEngine.Locations
{
    public class EconomicMultipler : IEconomicMultipler
    {
        public double SellingMultiplier { get; set; } = 0.8;
        public double BuyingMultiplier { get; set; } = 1.2;
        public void Convert(LAND land)
        {
            switch (land)
            {
                case LAND.Frozen_land:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Black_Mountains:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Crimson_Forrest:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Hidden_Temple:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Forrest:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Southen_fields:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Forgotten_sands:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                case LAND.Blacksands:
                    SellingMultiplier = 0.8;
                    BuyingMultiplier = 1.2;
                    break;
                default:
                    break;
            }
        }
    }
}
