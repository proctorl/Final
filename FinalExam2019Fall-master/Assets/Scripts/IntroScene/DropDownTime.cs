using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownTime : MonoBehaviour
{
    List<string> Time = new List<string>() { "Time", "1", "2", "Unlimited"};

    public Dropdown dropdown;
    public static int myIndex;

    public void Dropdown_IndexChanged(int index)
    {
        myIndex = index;
    }

    private void Update()
    {
        
        if (myIndex == 0)
        {
            myIndex = 1;

        }
    }
    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown.AddOptions(Time);
    }
}
