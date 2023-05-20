using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTime : MonoBehaviour
{
    public Text timerText;

    private static float currentTime = 60;
    private bool countDown = true;
    
    private bool hasLimit = true;
    public float timerLimit;
    public GameObject timeOutScreen;
    public GameObject timePopUp;
    public bool endGame;

    private bool hasFormat = true;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();


    private void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }

    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        if (hasLimit && currentTime < timerLimit)
        {
            currentTime = timerLimit;
            SetTimerText();
            enabled = false;
            if (timerLimit == 0)
            {
                TimeOutScreen();
                FindObjectOfType<TimeOutManager>().FinishTimer();
            }
        }
        SetTimerText();
    }

    private void SetTimerText()
    {
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }

    public enum TimerFormats
    {
        Whole,
        TenthDecimal,
        HundrethsDecimal
    }

    private void TimeOutScreen()
    {
        ScoreGame.save = true;
    }

    public void TimeOver()
    {
        timeOutScreen.SetActive(true);
        currentTime = 60;
    }

    public void RestartTime()
    {
        currentTime = 60;
    }

    public void MoreTime()
    {
        currentTime += 4;
        LeanTween.scale(timePopUp, new Vector3(1f, 1f, 1f), .8f).setEase(LeanTweenType.easeOutElastic);
    }
}
