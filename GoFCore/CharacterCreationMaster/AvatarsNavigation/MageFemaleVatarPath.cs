using GameEngine.CharacterCreationMaster.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class MageFemaleAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> MiniatureData { get; private set; } = new();
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public MageFemaleAvatarPaths()
        {
            for (int i = 1; i < 11; i++)
            {
                AvatarsData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\mageFemale\\{i}.jpg");
                MiniatureData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\mageFemale\\avatar{i}.png");
            }
        }
    }
}
