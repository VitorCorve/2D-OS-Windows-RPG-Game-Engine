using GameEngine.CharacterCreationMaster.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class WarriorMaleAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> MiniatureData { get; private set; } = new();
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public WarriorMaleAvatarPaths()
        {
            for (int i = 1; i < 11; i++)
            {
                AvatarsData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\warriorMale\\{i}.jpg");
                MiniatureData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\warriorMale\\avatar{i}.png");
            }
        }
    }
}
