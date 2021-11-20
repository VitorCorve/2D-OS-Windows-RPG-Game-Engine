namespace GameEngine.Locations.Interfaces.Services
{
    public interface ILocationBuilder
    {
        ILocation Build(TOWN currentTown);
    }
}
