using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject ballPrefab;

    public float xPos;
    public float yPos;

    void Start()
    {
        Transform();
    }

    public void Transform()
    {
        xPos = Random.Range(-6, 1);
        yPos = Random.Range(-1, 3);
        ballPrefab.transform.position = new Vector3(xPos, 1, yPos);
    }
}
