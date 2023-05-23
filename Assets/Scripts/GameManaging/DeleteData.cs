using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
    public GameObject deleteData, panel;

    public void Invoke()
    {
        panel.SetActive(true);
        FindObjectOfType<SoundManager>().Play("Click");       
    }
    public void Cancel()
    {
        panel.SetActive(false);
        FindObjectOfType<SoundManager>().Play("Click");
    }

    public void Erase()
    {
        PlayerPrefs.DeleteKey("faseConcluída");
        PlayerPrefs.DeleteKey("totalScore");
        PlayerPrefs.DeleteKey("skinPref");
        PlayerPrefs.DeleteKey("totalPoints");
        PlayerPrefs.DeleteKey("SavedScene");
        PlayerPrefs.DeleteKey("prefMoney");

        FindObjectOfType<SoundManager>().Play("Click");
        panel.SetActive(false);
    }
}
