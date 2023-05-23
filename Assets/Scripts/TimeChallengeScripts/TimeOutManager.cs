using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOutManager : MonoBehaviour
{
    [SerializeField] private static int scorePointsCol;      //amount of points in numbers
    [SerializeField] private static int scorePointsEnd;
    public Text scorePoints;                                 //points showed in text format
    public Text scorePointsRec;                              //points showed in text format if time reaches 0
    public GameObject[] itens;                               //Objects removed after time ends
    public GameObject pointsPopUp;                           //points animated on screen &
    public GameObject newRecord;
    private bool isTimeOver;                                 //what happens if time reaches 0

    private void Start()
    {
        PlayerPrefs.GetInt("totalPoints", scorePointsEnd);

        Time.timeScale = 1f;
    }

    private void Update()
    {
        scorePoints.text = scorePointsCol.ToString();
        scorePointsRec.text = scorePointsEnd.ToString();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Cesta") == true)
        {
            LeanTween.scale(pointsPopUp, new Vector3(1f, 1f, 1f), .8f).setEase(LeanTweenType.easeOutElastic);
            scorePointsCol++;
            FindObjectOfType<GlobalTime>().MoreTime();
            FindObjectOfType<SoundManager>().Play("Score");
            ScorePoints();
        }
    }

    public void FinishTimer()
    {
        isTimeOver = true;
        if (isTimeOver == true)
        {
            FindObjectOfType<GlobalTime>().TimeOver();
            itens[0].SetActive(false);
            FindObjectOfType<SoundManager>().Play("Start");
            FindObjectOfType<StartTEMusic>().FinishTEMusic();
            if(scorePointsCol > scorePointsEnd)
            {
                newRecord.SetActive(true);
                scorePointsEnd = scorePointsCol;
            }
        }
    }

    void ScorePoints()
    {
        PlayerPrefs.SetInt("totalPoints", scorePointsEnd);
        PlayerPrefs.Save();
    }

    public void RestartEvent()
    {
        scorePointsCol = 0;
    }
}
