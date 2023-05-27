using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveIcons : MonoBehaviour
{
    public GameObject[] icons;

    public void Remove()
    {
        for (int i = 0; i< icons.Length; i++)
        {
            icons[i].SetActive(false);
        }
    }
}
