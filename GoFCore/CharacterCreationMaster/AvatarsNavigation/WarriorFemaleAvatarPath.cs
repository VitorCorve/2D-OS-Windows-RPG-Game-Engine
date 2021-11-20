using GameEngine.CharacterCreationMaster.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class WarriorFemaleAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> MiniatureData { get; private set; } = new();
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public WarriorFemaleAvatarPaths()
        {
            for (int i = 1; i < 11; i++)
            {
                AvatarsData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\warriorFemale\\{i}.jpg");
                MiniatureData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\warriorFemale\\avatar{i}.png");
            }
        }
    }
}
