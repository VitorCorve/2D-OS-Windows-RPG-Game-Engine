namespace GameEngine.Data.Interfaces.Services
{
    public interface ISaveGameService
    {
        void Save(PlayerSaveData playerData, bool isAutoSave = false);
    }
}
