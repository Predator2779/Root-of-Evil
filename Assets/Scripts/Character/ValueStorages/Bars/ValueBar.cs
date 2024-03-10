using UnityEngine;
using UnityEngine.UI;

namespace Character.ValueStorages.Bars
{
    public class ValueBar : MonoBehaviour
    {
        [SerializeField] protected Slider _slider;

        public virtual void SetCurrentValue(float value) => _slider.value = value;
    }
}