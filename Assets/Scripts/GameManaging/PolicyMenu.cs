using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PolicyMenu : MonoBehaviour
{
    private string policyKey = "policy";

    void Start()
    {
        var accepted = PlayerPrefs.GetInt(policyKey, 0) == 1;

        if (accepted)
        {
            return;
        }
        SimpleGDPR.ShowDialog(new TermsOfServiceDialog().
            SetTermsOfServiceLink("https://sites.google.com/view/ggamingsites/in%C3%ADcio").
            SetPrivacyPolicyLink("https://sites.google.com/view/ggamingsites/in%C3%ADcio"),
            onMenuClosed);
    }

    private void onMenuClosed()
    {
        Debug.LogWarning("Policy accepted");
        PlayerPrefs.SetInt(policyKey, 1);
        SceneManager.LoadScene(1);
    }

    
}
