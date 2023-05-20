using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuMusic : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SoundManager>().Play("MenuTheme");
    }

    public void ChangeMusic()
    {
        FindObjectOfType<SoundManager>().StopPlaying("MenuTheme");
        FindObjectOfType<SoundManager>().Play("LevelTheme");
    }

    public void ChangeMusicTE()
    {
        FindObjectOfType<SoundManager>().StopPlaying("MenuTheme");
        FindObjectOfType<SoundManager>().Play("TETheme");
    }
}
