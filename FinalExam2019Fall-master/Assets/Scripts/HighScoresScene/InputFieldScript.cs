using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    public InputField input;
    public static string playerName;
    public void Update()
    {
        playerName = input.text;
    }
}
