using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 1;
    public float maxHealth;

    public Animator defeat;

    void Start()
    {
        defeat = GetComponent<Animator>();
        health = maxHealth;
    }

    void Update()
    {
        EnemyDefeat();
        FindObjectOfType<Counter>().IncreaseScore();
    }

    public void EnemyDefeat()
    {
        if (health <= 0)
        {
            defeat.Play("Explosion");
            Destroy(gameObject, defeat.GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
