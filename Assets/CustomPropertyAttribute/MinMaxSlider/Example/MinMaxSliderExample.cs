using UnityEngine;

public class MinMaxSliderExample : MonoBehaviour
{
    [MinMaxSlider(0f, 10f)] public MinMax rangeMinMax = new MinMax(4f, 8f);
}