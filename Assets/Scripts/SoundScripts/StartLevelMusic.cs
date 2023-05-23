using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartLevelMusic : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SoundManager>().Play("LevelTheme");
        FindObjectOfType<SoundManager>().Play("Start");
    }

    public void ChangeMusic()
    {
        FindObjectOfType<SoundManager>().StopPlaying("LevelTheme");
        FindObjectOfType<SoundManager>().Play("MenuTheme");
    }

    public void FinishLevelMusic()
    {
        FindObjectOfType<SoundManager>().StopPlaying("LevelTheme");
        FindObjectOfType<SoundManager>().Play("LevelComplete");
        FindObjectOfType<SoundManager>().StopPlaying("BallHitplate");
        FindObjectOfType<SoundManager>().StopPlaying("BallHitGround");
    }
}
