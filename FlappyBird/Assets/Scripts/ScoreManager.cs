using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
    public int score = 0;
    public void AddPoints()
    {
        score++;
        if (score >= PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }

    public void ResetScore()
    {
        score = 0;
    }

}
