using UnityEngine;
using UnityEngine.UI;

namespace Character.ValueStorages.Bars
{
    public class GradientValueBar : ValueBar
    {
        [SerializeField] private Gradient _gradient;
        [SerializeField] protected Image _fill;
        
        public override void SetCurrentValue(float value)
        {
            base.SetCurrentValue(value);
            _fill.color = _gradient.Evaluate(_slider.normalizedValue);
        }
    }
}