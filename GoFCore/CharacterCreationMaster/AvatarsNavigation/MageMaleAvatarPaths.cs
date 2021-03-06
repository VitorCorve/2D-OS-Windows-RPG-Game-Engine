using GameEngine.CharacterCreationMaster.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class MageMaleAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> MiniatureData { get; private set; } = new();
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public MageMaleAvatarPaths()
        {
            for (int i = 1; i < 11; i++)
            {
                AvatarsData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\mageMale\\{i}.jpg");
                MiniatureData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\mageMale\\avatar{i}.png");
            }
        }
    }
}
