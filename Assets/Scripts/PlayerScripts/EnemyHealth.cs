using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health = 1;
    public float maxHealth;
    public Image healthBar;
    public Animator defeat;

    void Start()
    {
        defeat = GetComponent<Animator>();
        health = maxHealth;
    }

    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        EnemyDefeat();
        if (Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }
    }

    public void EnemyDefeat()
    {
        if (health <= 0)
        {
            defeat.Play("Explosion");
            Destroy(gameObject, defeat.GetCurrentAnimatorStateInfo(0).length);
            Invoke("IncreaseScore", 1f);
        }
    }

    bool IncreaseScore()
    {
        FindObjectOfType<Counter>().IncreaseScore(1);
        return true;
    }
}
