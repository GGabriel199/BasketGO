using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAdsButtonCheck : MonoBehaviour
{
    public GameObject removeAdsButton;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("PURCHASED_REMOVEADS") == 1) removeAdsButton.SetActive(false);
    }
}
