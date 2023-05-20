using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpaceManager : MonoBehaviour
{
    #region SingletonClass

    public static PlayerSpaceManager instance;
    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
