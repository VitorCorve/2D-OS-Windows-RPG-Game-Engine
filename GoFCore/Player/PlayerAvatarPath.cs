using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player
{
    public class PlayerAvatarPath
    {
        public string MiniaturePath { get; set; }
        public string Path { get; set; }
        public PlayerAvatarPath(string path) => Path = path;
        public PlayerAvatarPath() { }
    }
}
