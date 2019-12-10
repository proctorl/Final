using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSpeed : MonoBehaviour
{
    List<string> Speed = new List<string>() { "Speed", "1", "2", "3" };

    public Dropdown dropdown;
    public static int myIndex;
    public static int speed;

    public void Dropdown_IndexChanged(int index)
    {
        myIndex = index;
        speed = index;
    }

    private void Update()
    {
        if (myIndex == 0)
        {
            myIndex = 1;

        }
        if (speed == 0)
        {
           speed = 1;

        }
    }
    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(Speed);
    }
}
