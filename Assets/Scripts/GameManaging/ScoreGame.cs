using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreGame : MonoBehaviour
{
    [SerializeField] private int playerMoney;
    private int scoreStars;

    private const string prefMoney = "prefMoney";

    private bool win;
    public static bool save;

    public GameObject[] stars, itens;
    public GameObject winScreen, cancelCol, cancelScore, msg, scoreScreen;

    public Slider totalCoinsSlider;
    private Text scoreTxt;

    public ScoreGame Instance;

    private void Awake()
    {
        playerMoney = PlayerPrefs.GetInt("prefMoney");
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1f;
        scoreStars = 0;
        win = false;
        save = false;
        scoreScreen = GameObject.FindGameObjectWithTag("Score");
        scoreTxt = scoreScreen.GetComponent<Text>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coins")
        {
            FindObjectOfType<SoundManager>().Play("CoinCollected");
            scoreStars++;
            totalCoinsSlider.value++;
            Destroy(other.gameObject);
            playerMoney++;
            Destroy(other.gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Finish") == true)
        {
            FindObjectOfType<StartLevelMusic>().FinishLevelMusic();
            CoinCollect();
            WinScreen();
            Time.timeScale = 0.4f;
            Destroy(cancelCol);
            Destroy(cancelScore);
        }
    }

    private void WinScreen()
    {
        save = true;
        win = true;
        scoreStars++;
        winScreen.SetActive(true);

        if (SceneManager.GetActiveScene().buildIndex > PlayerPrefs.GetInt("faseConcluída"))
        {
            PlayerPrefs.SetInt("faseConcluída", SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.Save();
        }

        if (win == true)
        {
            itens[0].SetActive(false);
            itens[1].SetActive(false);
            itens[2].SetActive(false);
        }
    }

    void CoinCollect()
    {
        if (scoreStars <= 0f)
        {
            stars[0].SetActive(true);
        }
        else if (scoreStars <= 1)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else if (scoreStars <= 2)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
            playerMoney += 10;
            msg.SetActive(true);
        }
    }

    void Update()
    {
        scoreTxt.text = playerMoney.ToString();
        SaveScore();
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (playerMoney >= moneyToRemove)
        {
            playerMoney -= moneyToRemove;
            PlayerPrefs.SetInt(prefMoney, playerMoney);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SaveScore()
    {
        if (save == true)
        {
            PlayerPrefs.SetInt("prefMoney", playerMoney);
            PlayerPrefs.Save();
        }
    }
    public void ReceiveReward()
    {
        if (PlayerPrefs.GetInt("PURCHASED_REMOVEADS") == 1) playerMoney +=5;

        playerMoney += 5;
    }
}
