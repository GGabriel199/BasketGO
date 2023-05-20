using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    private int continueScene;

    public LevelAnim levelLoader;

    public void Continue()
    {
        continueScene = PlayerPrefs.GetInt("SavedScene");

        if (continueScene != 0)
            SceneManager.LoadScene(continueScene);
        else
            return;

        levelLoader.Transition(sceneName);
    }

    public void ChangeS()
    {
        FindObjectOfType<SoundManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public class SceneFunctions : MonoBehaviour
    {
        public void ChangeSceneByAddingIndex(int indexToAdd)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + indexToAdd);
        }
    }
}
