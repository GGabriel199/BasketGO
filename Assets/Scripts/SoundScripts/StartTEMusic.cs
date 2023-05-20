using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTEMusic : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SoundManager>().Play("TETheme");
    }

    public void ChangeMusic()
    {
        FindObjectOfType<SoundManager>().StopPlaying("TETheme");
        FindObjectOfType<SoundManager>().Play("MenuTheme");
    }

    public void FinishTEMusic()
    {
        FindObjectOfType<SoundManager>().StopPlaying("TETheme");
    }
}
