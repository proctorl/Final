using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void GameScene()
    {
        Debug.Log(DropDownTime.myIndex);
        SceneManager.LoadScene("3Game");
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void HighScoreScene()
    {
        Debug.Log(DropDownTime.myIndex);
        SceneManager.LoadScene("2HighScores");
    }

    public void ExitScene()
    {
        ScoresScript.Write(InputFieldScript.playerName, ScoreKeeper.newScore);
        SceneManager.LoadScene("4Exit");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
