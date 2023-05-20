using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void Menu()
    {
        FindObjectOfType<SoundManager>().Play("Click");
        SceneManager.LoadScene(1);
    }
}
