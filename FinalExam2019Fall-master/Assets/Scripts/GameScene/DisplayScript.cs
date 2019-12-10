using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour
{
    public Text size;
    public Text speed;
    public Text time;
    float timer;

    private void Start()
    {
        if (DropDownTime.myIndex == 1)
        {
            timer = 60;
            
        }

        if (DropDownTime.myIndex == 2)
        {
            timer = 120;
        }

        size.text = SliderScript.sliderVal.ToString();
        speed.text = DropDownSpeed.myIndex.ToString();
    }
    public void Update()
    {
        if (DropDownTime.myIndex != 3)
        {
            timer -= 1 * Time.deltaTime;
            time.text = Mathf.Round(timer).ToString();
        }
    }
}
