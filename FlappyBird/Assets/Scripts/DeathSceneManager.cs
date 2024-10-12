using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSceneManager : MonoBehaviour
{
    [SerializeField] GameObject deathScene;

    private void Start()
    {
        deathScene.SetActive(false);
    }
    public void SetActiveScene(bool condition)
    {
        deathScene.SetActive(condition);
    }
}
