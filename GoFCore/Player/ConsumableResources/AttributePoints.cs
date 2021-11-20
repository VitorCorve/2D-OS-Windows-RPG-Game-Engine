using GameEngine.Abstract.PlayerConsumable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Player.ConsumableResources
{
    public class AttributePoints : IConsumableResource
    {
        public CONSUMABLE_NAME Name { get; } = CONSUMABLE_NAME.Attribute_point;
        public int Value { get; set; }
    }
}
