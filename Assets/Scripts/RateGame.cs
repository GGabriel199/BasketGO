using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateGame : MonoBehaviour
{
    public static RateGame instance;
    private string rateKey = "rateDenied";
    public GameObject panel;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        PlayerPrefs.GetInt(rateKey);
    }

    public void onMenuClosed()
    {
        panel.SetActive(false);
        Debug.LogWarning("Rate game denied");
        PlayerPrefs.SetInt(rateKey, 1);
        var denied = PlayerPrefs.GetInt(rateKey, 0) == 1;

        if (denied)
        {
            return;
        }

    }
    public void RateUs()
    {
#if UNITY_ANDROID
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.ggamingstudio.com.unity");
#elif UNITY_IPHONE
Application.OpenURL("");

#endif
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PopUp()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}