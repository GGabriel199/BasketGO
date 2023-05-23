using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRatePanel : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        panel.SetActive(true);
        FindObjectOfType<SoundManager>().Play("Click");
    }
}
