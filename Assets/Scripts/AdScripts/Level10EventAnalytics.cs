using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class Level10EventAnalytics
{
    public static string totalCoins;
    public static void OnEventCall()
    {
        Analytics.CustomEvent("tunnelLevel1", new Dictionary <string,object>
        {
            { "prefMoney", totalCoins}
        });
    }
}
