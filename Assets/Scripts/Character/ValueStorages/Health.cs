using Character.ValueStorages.Bars;

namespace Character.ValueStorages
{
    public class Health : ValueStorage
    {
        public Health(float maxValue) : base(maxValue)
        {
        }

        public Health(float maxValue, ValueBar bar) : base(maxValue, bar)
        {
        }
    }
}