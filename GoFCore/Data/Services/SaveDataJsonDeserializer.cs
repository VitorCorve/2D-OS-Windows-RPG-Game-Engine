using GameEngine.Data.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.IO;

namespace GameEngine.Data.Services
{
    public class SaveDataJsonDeserializer : ISaveDataJsonDeserializer
    {
        public PlayerSaveData Deserialize(string filePath)
        {
            var playerSaveData = JsonConvert.DeserializeObject<PlayerSaveData>(File.ReadAllText(filePath), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            return playerSaveData;
        }
    }
}
