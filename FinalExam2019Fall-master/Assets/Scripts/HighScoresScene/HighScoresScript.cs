using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoresScript : MonoBehaviour
{
    public Text scoresText;

    public void Update()
    {
        scoresText.text = ScoresScript.Read();
    }
}
