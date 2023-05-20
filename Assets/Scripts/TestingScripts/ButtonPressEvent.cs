using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class ButtonPressEvent : MonoBehaviour
{
    public void OnButtonPress()
    {
        Debug.Log("CustomEvent sent to Analytics");
        Analytics.CustomEvent("buttonPress");
    }

}
