using GameEngine.Locations.Interfaces;

namespace GameEngine.Locations
{

    public class Location : ILocation
    {
        private string _LocationDescription;
        private string _LocationImagePresenterPath;
        private string _LocationBGImagePresenterPath;
        public LAND Land { get; set; }
        public TOWN Town { get; set; }
        public string LocationDescription { get => _LocationDescription; set => _LocationDescription = value; }
        public string LocationImagePresenterPath { get => _LocationImagePresenterPath; set => _LocationImagePresenterPath = value; }
        public string LocationBGImagePresenterPath { get => _LocationBGImagePresenterPath; set => _LocationBGImagePresenterPath = value; }
        public EconomicMultipler Multipliers { get; set; } = new();
    }
}
