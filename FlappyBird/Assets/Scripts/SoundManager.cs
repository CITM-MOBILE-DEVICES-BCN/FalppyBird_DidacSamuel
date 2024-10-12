using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource pointFX;
    public AudioSource deathFX;
    
    public void PlayScoreEfect()
    {
        pointFX.Play();
    }
    public void PlayDeathSoundEffect()
    {
        deathFX.Play();
    }
}
