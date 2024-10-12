using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI score;

    public void Update()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore",0).ToString();   
        score.text = GameManager.instance.facade.GetScore().ToString();   
    }
}
