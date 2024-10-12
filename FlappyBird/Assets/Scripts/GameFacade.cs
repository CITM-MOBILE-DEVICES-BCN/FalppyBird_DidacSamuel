using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade
{
    SoundManager soundManager;
    ScoreManager scoreManager;
    DeathSceneManager deathSceneController;

    public void Init(SoundManager soundManager, DeathSceneManager deathSceneController)
    {
        scoreManager = new ScoreManager();
        this.soundManager = soundManager;
        this.deathSceneController = deathSceneController;
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
        deathSceneController.SetActiveScene(true);
    }

    public int GetScore()
    {
        return scoreManager.score;
    }
}
