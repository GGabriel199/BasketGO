using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{

    [Header("References")]
    private Rigidbody2D oRigidbody2D;
    private Rigidbody2D yRigidbody2D;

    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
        yRigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void PlayerImpulseX(float impulseForceX)
    {
        oRigidbody2D.AddForce(new Vector2(impulseForceX, 0f), ForceMode2D.Impulse);
    }
    public void PlayerImpulseY(float impulseForceY)
    {
        yRigidbody2D.AddForce(new Vector2(0f, impulseForceY), ForceMode2D.Impulse);
    }
}
