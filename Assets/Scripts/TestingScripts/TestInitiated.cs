using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class TestInitiated : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Test Initialized");
        Analytics.CustomEvent("testInitialized");
    }

}
