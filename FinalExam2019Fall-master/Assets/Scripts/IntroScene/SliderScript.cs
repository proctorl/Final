﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider slider;
    public static float sliderVal;

    void SetSliderValue()
    {
        sliderVal = slider.value;
    }

}
