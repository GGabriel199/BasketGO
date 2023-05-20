using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    private int counter;
    public Text counterTxt;
    public Animator faint;

    void Start()
    {
        PlayerPrefs.GetInt("aliensDefeated", counter);
        faint = GetComponent<Animator>();
        maxHealth = health;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counterTxt.text = counter.ToString();

        if (health <= 0)
        {
            Destroy(gameObject, 1.1f);
            faint.Play("Explosion");
            SaveScore();
            counter++;
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("aliensDefeated", counter);
        PlayerPrefs.Save();
    }
}
