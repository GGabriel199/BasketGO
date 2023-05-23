using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimeEventManager : MonoBehaviour
{
    public string timeOutSceneName;

    public void ChangeScene()
    {
        FindObjectOfType<SoundManager>().Play("Click");
        SceneManager.LoadScene(timeOutSceneName);
        FindObjectOfType<GlobalTime>().RestartTime();
        FindObjectOfType<TimeOutManager>().RestartEvent();
        FindObjectOfType<StartTEMusic>().ChangeMusic();
    }

    public void ChangeSceneByAddingIndex()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
