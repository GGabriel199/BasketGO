using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenAnim : MonoBehaviour
{
    [SerializeField]

    GameObject panel;
    public GameObject[] buttons;
    public GameObject[] stars;

    void Start()
    {
        LeanTween.scale(panel, new Vector3(1.5f, 1.5f, 1.5f), .5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(Stars);
    }

    void Stars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            LeanTween.scale(stars[0], new Vector3(1f, 1f, 1f), .5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(PopUpButton);
            LeanTween.scale(stars[1], new Vector3(1f, 1f, 1f), .5f).setEase(LeanTweenType.easeOutElastic).setDelay(.4f).setOnComplete(PopUpButton);
            LeanTween.scale(stars[2], new Vector3(1f, 1f, 1f), .5f).setEase(LeanTweenType.easeOutElastic).setDelay(.8f).setOnComplete(PopUpButton);
        }
    }

    void PopUpButton()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            LeanTween.scale(buttons[i], new Vector3(1f, 1f, 1f), .7f).setEase(LeanTweenType.easeOutElastic).setDelay(.5f);
        }    
    }
}
