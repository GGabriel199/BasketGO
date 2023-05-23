using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    public string sceneName;
    public LevelAnim levelLoader;

    public void ChangeS()
    {
        FindObjectOfType<SoundManager>().Play("Click");

        SceneManager.LoadScene(sceneName);
        levelLoader.Transition(sceneName);
    }
}
