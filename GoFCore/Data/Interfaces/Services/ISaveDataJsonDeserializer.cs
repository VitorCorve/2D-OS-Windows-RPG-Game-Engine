namespace GameEngine.Data.Interfaces.Services
{
    public interface ISaveDataJsonDeserializer
    {
        PlayerSaveData Deserialize(string characterName);
    }
}
