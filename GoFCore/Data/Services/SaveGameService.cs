using GameEngine.Data.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.IO;

namespace GameEngine.Data.Services
{
    public class SaveGameService : ISaveGameService
    {
        public void Save(PlayerSaveData playerData, bool isAutoSave = false)
        {
            string saveFileName;

            if (isAutoSave)
            {
                playerData.IsAutoSave = true;
                saveFileName = "Autosave";
            }
            else saveFileName = playerData.Name + $" {DateTime.Now:yy.MM.dd H.mm.ss}";

              var jsonData = JsonConvert.SerializeObject(playerData, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            string workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\"))
                Directory.CreateDirectory($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\");
            
            File.WriteAllText($"{workingDirectory}\\Games\\Game of Frameworks\\Saves\\{saveFileName}.json", jsonData);
        }
        public void Save(PlayerLoadData playerData)
        {
            var dataConverter = new GameLoadToGameSaveDataConvertationService();
            Save(dataConverter.Covert(playerData));
        }
    }
}
