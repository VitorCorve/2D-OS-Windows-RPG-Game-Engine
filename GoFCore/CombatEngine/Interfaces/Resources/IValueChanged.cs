
namespace GameEngine.CombatEngine.Interfaces.Resources
{
    public interface IValueChanged
    {
        delegate void ValueChanged();
        event ValueChanged Notify;
    }
}
