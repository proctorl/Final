using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Toggle toggle;
    public GameObject button;

    private void Start()
    {
        button.SetActive(false);
    }
    public void EnableButton()
    {
        if (toggle.isOn)
            button.SetActive(true);
        else
            button.SetActive(false);
    }

    
}
