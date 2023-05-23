using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeCanvas : MonoBehaviour
{
    public GameObject canvas;
    public Transform objectToFreeze;
    public float y;

    void FixedUpdate()
    {
        if (canvas.activeInHierarchy)
        {
            // Set position of objectToFreeze
            objectToFreeze.position = new Vector2(objectToFreeze.position.x, y);
            // Use this instead if you want to freeze the object wich has this script
            transform.position = new Vector2(transform.position.x, y);
        }
    }
}
