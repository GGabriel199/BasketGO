using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<SoundManager>().Play("Click");
        SceneManager.LoadScene(3);
        FindObjectOfType<StartMenuMusic>().ChangeMusic();
    }
}
