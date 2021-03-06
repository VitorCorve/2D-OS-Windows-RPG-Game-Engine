using GameEngine.CharacterCreationMaster.Interfaces;
using System;
using System.Collections.Generic;

namespace GameEngine.CharacterCreationMaster.AvatarsNavigation
{
    public class RogueFemaleAvatarPaths : IAvatarPaths
    {
        public Dictionary<int, string> MiniatureData { get; private set; } = new();
        public Dictionary<int, string> AvatarsData { get; private set; } = new();
        public RogueFemaleAvatarPaths()
        {
            for (int i = 1; i < 11; i++)
            {
                AvatarsData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\rogueFemale\\{i}.jpg");
                MiniatureData.Add(i, $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\rogueFemale\\avatar{i}.png");
            }
        }
    }
}
