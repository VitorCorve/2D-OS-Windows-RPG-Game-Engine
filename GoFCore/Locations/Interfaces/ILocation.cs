namespace GameEngine.Locations.Interfaces
{
    public interface ILocation
    {
        string LocationDescription { get; }
        LAND Land { get; set; }
        TOWN Town { get; set; }
        string LocationImagePresenterPath { get; }
        string LocationBGImagePresenterPath { get; }
        EconomicMultipler Multipliers { get; }
    }
}
