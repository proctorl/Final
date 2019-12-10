using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoresScript
{
    public static void Write(string playerName, int score)
    {
        string path = "Assets/scores.txt";

        StreamWriter w = new StreamWriter(path, true);
        w.WriteLine(playerName.ToString() + ", " + score);
        w.Close();
    }

    public static string Read()
    {
        string path = "Assets/scores.txt";
        string scores;

        StreamReader r = new StreamReader(path);
        scores = r.ReadToEnd();
        r.Close();

        return scores;
    }
}
