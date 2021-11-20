using GameEngine.Locations.Interfaces;
using GameEngine.Locations.Interfaces.Services;
using System;


namespace GameEngine.Locations.Services
{
    public class LocationBuilder : ILocationBuilder
    {
        public ILocation Build(TOWN currentTown)
        {
            switch (currentTown)
            {
                case TOWN.Roughwark:
                    return CreateRoughwarkLocationData();
                case TOWN.Ironhide:
                    return CreateIronhideLocationData();
                case TOWN.Elfinel:
                    return CreateElfinelLocationData();
                case TOWN.Chartringfall:
                    return CreateChartringfallLocationData();
                case TOWN.Anvilrest:
                    return CreateAnvilrestLocationData();
                case TOWN.Frozencore:
                    return CreateFrozencoreLocationData();
                case TOWN.Dark_Fortress:
                    return CreateDarkFortressLocationData();
                default:
                    return CreateRoughwarkLocationData();
            }
        }
        private Location CreateRoughwarkLocationData()
        {
            return new Location
            {
                Town = TOWN.Roughwark,
                Land = LAND.Frozen_land,
                LocationDescription = "Raised under a peninsula, the port of Roughwark is home to orcs lead by Commander Golag. This port wasn't built by a peninsula by accident, as it has dark ruins, which is of great importance to the people of north and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\RoughwarkCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\RoughwarkBG.jpg"
            };
        }
        private Location CreateIronhideLocationData()
        {
            return new Location
            {
                Town = TOWN.Ironhide,
                Land = LAND.Black_Mountains,
                LocationDescription = "Ironhide next to a bluff, the township of Mystohr is home to fairies lead by Lord Ironfist. This township wasn't built by a bluff by accident, as it has unique wildlife, which is of great importance to the people of west and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\IronhideCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\IronhideBG.jpg"
            };
        }
        private Location CreateElfinelLocationData()
        {
            return new Location
            {
                Town = TOWN.Elfinel,
                Land = LAND.Crimson_Forrest,
                LocationDescription = "Elfinel on the base of a field, the settlement of Knowgninor is home to elves lead by Mayor Jaafan. This settlement wasn't built by a field by accident, as it has dark ruins, which is of great importance to the people of middle earth and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\ElfinelCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\ElfinelBG.jpg"
            };
        }
        private Location CreateChartringfallLocationData()
        {
            return new Location
            {
                Town = TOWN.Chartringfall,
                Land = LAND.Southen_fields,
                LocationDescription = "Positioned around a canal, the village of Chartringfall. This village wasn't built by a canal by accident, as it has hidden secrets, which is of great importance to the people of south and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\ChartringfallCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\ChartringfallBG.jpg"
            };
        }
        private Location CreateAnvilrestLocationData()
        {
            return new Location
            {
                Town = TOWN.Anvilrest,
                Land = LAND.Crimson_Forrest,
                LocationDescription = "Built easter of Crimson forrest, the town of Anvilrest is home to dwarves lead by Officer Urmbrek. This hamlet wasn't built by a tundra by accident, as it has ancient histories, which is of great importance to the people of Anvilrest and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\AnvilrestCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\AnvilrestBG.jpg"
            };
        }
        private Location CreateFrozencoreLocationData()
        {
            return new Location
            {
                Town = TOWN.Frozencore,
                Land = LAND.Blacksands,
                LocationDescription = "Formed beside a frozen lands, the earth of Frozencore is home to ash elves lead by King Ralfagrom. This crossroad wasn't built by a woodlands by accident, as it has a broken, hidden library, which is of great importance to the people of Frozencore and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\FrozencoreCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\FrozencoreBG.jpg"
            };
        }
        private Location CreateDarkFortressLocationData()
        {
            return new Location
            {
                Town = TOWN.Dark_Fortress,
                Land = LAND.Southen_fields,
                LocationDescription = "Based on top of a hill, the outpost of DarkFortress is home to humans lead by Ms. Eustice. This outpost wasn't built by a hill by accident, as it has a broken, hidden library, which is of great importance to the people of south and its success.",
                LocationImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\WorldMap\\Towns\\Dark_FortressCut.jpg",
                LocationBGImagePresenterPath = $"{Environment.CurrentDirectory}\\Data\\Locations\\BackgroundPresenterImages\\DarkFortressBG.jpg"
            };
        }
    }
}
