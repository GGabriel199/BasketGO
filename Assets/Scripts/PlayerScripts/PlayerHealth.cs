using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float health;
    public float maxHealth;
    public Image healthBar;
    public GameObject deadPanel;
    public Animator anim;

    void Start()
    {
        Time.timeScale = 1;
        maxHealth = health;
        InterstitialAd.instance.deaths++;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0)
        {
            FindObjectOfType<Counter>().SaveScore();
            anim.Play("PlayerExplosion");
            Invoke("End", .5f);
        }
    }

    public void End()
    {
        deadPanel.SetActive(true);
        Time.timeScale = 0f;
        if (InterstitialAd.instance.deaths >= 3)
        {
            InterstitialAd.instance.deaths = 0;
            InterstitialAd.instance.ShowAd();
        }
    }

    public void Revive()
    {
        deadPanel.SetActive(false);
        Time.timeScale = 1;
        health += 100;
    }
}
