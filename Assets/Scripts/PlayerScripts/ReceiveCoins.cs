using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveCoins : MonoBehaviour
{
    public Button coinRwrd;
    [SerializeField] private int playerMoney;

    private void Awake()
    {
        playerMoney = PlayerPrefs.GetInt("totalScore");
    }

    public void ReceiveReward()
    {
        playerMoney += 50;
        coinRwrd.interactable = false;
        PlayerPrefs.SetInt("totalScore", playerMoney);
    }
}
