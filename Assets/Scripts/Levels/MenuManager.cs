using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject[] itens;

    [SerializeField] public GameObject menuPanel;
    [SerializeField] public GameObject optionsScreen;
    [SerializeField] public GameObject levelScreen;
    [SerializeField] public GameObject skinScreen;
    [SerializeField] public GameObject languageScreen;
    [SerializeField] public GameObject gameModePanel;


    public void PauseButton()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0f;
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void ResumeButton()
    {
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void Home(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void Options()
    {
        optionsScreen.SetActive(true);
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void Back()
    {
        optionsScreen.SetActive(false);
        menuPanel.SetActive(true);
        levelScreen.SetActive(false);
        skinScreen.SetActive(false);
        languageScreen.SetActive(false);
        gameModePanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("ClickOut");
    }

    public void Level()
    {
        levelScreen.SetActive(true);
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void SkinShop()
    {
        skinScreen.SetActive(true);
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void LanguageChooser()
    {
        languageScreen.SetActive(true);
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void GameMode()
    {
        gameModePanel.SetActive(true);
        menuPanel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }
}
