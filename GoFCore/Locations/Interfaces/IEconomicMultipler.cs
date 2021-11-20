namespace GameEngine.Locations.Interfaces
{
    public interface IEconomicMultipler
    {
        double SellingMultiplier { get; }
        double BuyingMultiplier { get; }
        void Convert(LAND land);
    }
}
