using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject pausePanel;
    [SerializeField] public GameObject optionsPanel;

    public void PauseButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        FindObjectOfType<SoundManager>().Play("Click");
    }
    
    public void Home(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
        FindObjectOfType<SoundManager>().Play("Click");
    }
    
    public void Options()
    {
        Time.timeScale = 0f;
        optionsPanel.SetActive(true);
        pausePanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void Back()
    {
        optionsPanel.SetActive(false);
        pausePanel.SetActive(true);
        FindObjectOfType<SoundManager>().Play("ClickOut");
    }
}
