using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Advertisements;
using UnityEngine.UI;



public class MonetizationManager : MonoBehaviour
{
    public void AddCoins(int coinsToAdd)
    {
        int coins = PlayerPrefs.GetInt("prefMoney");
        coins += coinsToAdd;
        PlayerPrefs.SetInt("prefMoney", coins);
        PlayerPrefs.Save();
    }

    public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id.Equals("coinspack1"))
        {
            AddCoins(1000);
        }

        else if (product.definition.id.Equals("stage2"))
        {
            PlayerPrefs.SetInt("PURCHASED_STAGE2", 1);
            PlayerPrefs.Save();
        }

        else if (product.definition.id.Equals("removeads"))
        {
            PlayerPrefs.SetInt("PURCHASED_REMOVEADS", 1);
            PlayerPrefs.Save();
        }
    }

    public void OnPurchaseFailed()
    {
        Debug.Log("Purchase Failed");
    }

    //------------------------------------------------------------

    public static void CheckSubscription()
    {
        Debug.Log("ChekSubscription");

#if !UNITY_EDITOR

        Product removeads = CodelessIAPStoreListener.Instance.GetProduct("removeads");
        if (removeads.hasReceipt)
        {
            SubscriptionManager removeAdsManager = new SubscriptionManager(removeads, null);
            if((removeAdsManager).getSubscriptionInfo().isSubscribed() != Result.True)
            {
                PlayerPrefs.SetInt("PURCHASED_REMOVEADS", 0);
                PlayerPrefs.Save();
                FindObjectOfType<BannerAds>().ShowBannerAd();
            }
        }
#endif
    }
}
