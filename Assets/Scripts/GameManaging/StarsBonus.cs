using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsBonus : MonoBehaviour
{
    public int scoreCoins;
    public GameObject bonusMsg;
    public GameObject[] stars;

    private void Awake()
    {
        scoreCoins = PlayerPrefs.GetInt("totalScore");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            scoreCoins++;
            Destroy(other);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Finish") == true)
        {
            CoinCollect();
        }
    }

    void CoinCollect()
    {
        if (scoreCoins <= 0f)
        {
            stars[0].SetActive(true);
        }
        else if (scoreCoins <= 1)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else if (scoreCoins <= 2)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
            scoreCoins += 10;
            bonusMsg.SetActive(true);
            PlayerPrefs.SetInt("totalScore", scoreCoins);
        }
    }
}
