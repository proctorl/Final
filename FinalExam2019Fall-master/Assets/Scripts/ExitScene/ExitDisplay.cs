using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitDisplay : MonoBehaviour
{
    public Text score;
    public Text highScores;

    private void Update()
    {
        score.text = (InputFieldScript.playerName + ", " + ScoreKeeper.newScore.ToString());
        highScores.text = ScoresScript.Read();
    }
}
