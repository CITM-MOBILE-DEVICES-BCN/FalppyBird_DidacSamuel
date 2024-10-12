using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isDead = false;
    public SoundManager soundManager;
    public DeathSceneManager deathSceneController;
    public GameFacade facade = new GameFacade();

    // Start is called before the first frame update
    void Start()
    { 
        facade.Init(soundManager, deathSceneController);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
