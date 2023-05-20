using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] buttons;

    public void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i + 3 > PlayerPrefs.GetInt("faseConcluída"))
            {
                buttons[i].interactable = false;
            }
        }
    }
}
