using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private static int counter;
    private int counterNow;
    public Text counterTxt;
    public Text totalAliensDefeated;
    public GameObject newRecord;

    void Start()
    {
        PlayerPrefs.GetInt("aliensDefeated", counter);
        counterNow = 0;
    }

    void Update()
    {
        counterTxt.text = counterNow.ToString();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("aliensDefeated", counter);
        PlayerPrefs.Save();
        totalAliensDefeated.text = counter.ToString();
    }

    public void IncreaseScore()
    {
        if(FindObjectOfType<EnemyHealth>().health <= 0)
        {
            counterNow++;
            FindObjectOfType<SoundManager>().Play("BallHitBasket");
            if (counterNow > counter)
            {
                counter = counterNow;
                newRecord.SetActive(true);
            }
        }
    }
}
