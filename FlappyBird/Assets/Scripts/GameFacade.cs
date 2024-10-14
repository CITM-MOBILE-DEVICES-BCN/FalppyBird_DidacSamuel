using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade
{
    SoundManager soundManager;
    ScoreManager scoreManager;
    DeathSceneManager deathSceneManager;

    public void Init(SoundManager soundManager, DeathSceneManager deathSceneManager)
    {
        scoreManager = new ScoreManager(); 
        this.soundManager = soundManager;
        this.deathSceneManager = deathSceneManager;
    }

    public void PipePassed()
    {
        scoreManager.AddPoints();
        soundManager.PlayScoreEfect();
    }

    public void Death()
    {
        scoreManager.ResetScore();
        if (!GameManager.instance.isDead)
        {
            soundManager.PlayDeathSoundEffect();
        }
        GameManager.instance.isDead = true;
        deathSceneManager.SetActiveScene(true);
    }

    public int GetScore()
    {
        return scoreManager.score;
    }
}
