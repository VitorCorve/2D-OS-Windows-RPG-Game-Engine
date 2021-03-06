using GameEngine.CombatEngine.Interfaces;

namespace GameEngine.Player.ConditionResources
{
    public class Health : IConditionResourceType
    {
        private int _value;
        public int Value 
        {
            get { return _value; }
            set { _value = ValidateValue(value); }
        }
        public int MaxValue { get; private set; }
        public RESOURCE_NAME Name { get; private set; } = RESOURCE_NAME.Health;

        public Health(int value)
        {
            MaxValue = value;
            Value = value;
        }
        public Health()
        {

        }

        private int ValidateValue(int value)
        {
            if (value <= 0)
            {
                return 0;
            }


            if (value > MaxValue)
                return MaxValue;

            else
                return value;
        }
    }
}
