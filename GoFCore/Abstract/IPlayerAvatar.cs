using GameEngine.Player;

namespace GameEngine.Abstract
{
    public interface IPlayerAvatar
    {
        int ID { get; }
        string Path { get; }
        string MiniaturePath { get; }
        SPECIALIZATION Specialization { get; }
    }
}
