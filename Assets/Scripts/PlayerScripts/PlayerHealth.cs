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

    void Start()
    {
        Time.timeScale = 1;

        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
            deadPanel.SetActive(true);
        }
    }

    public void Revive()
    {
        deadPanel.SetActive(false);
        Time.timeScale = 1;
        gameObject.SetActive(true);
        health += 100;
    }
}
