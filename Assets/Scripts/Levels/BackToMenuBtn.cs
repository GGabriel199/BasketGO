using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuBtn : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
