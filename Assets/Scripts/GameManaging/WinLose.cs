using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{    
    public Rigidbody2D ball;
    public Transform respawnPosition;
    public Collider2D other;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("LoadRestart", 2f);
        }

    }

    void LoadRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        InterstitialAd.instance.deaths++;
        if (InterstitialAd.instance.deaths >= 5)
        {
            InterstitialAd.instance.deaths = 0;
            InterstitialAd.instance.ShowAd();
        }
    }
}
