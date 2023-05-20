using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float trampolineForceX;
    public float trampolineForceY;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Impulse>().PlayerImpulseX(trampolineForceX);
            collision.gameObject.GetComponent<Impulse>().PlayerImpulseY(trampolineForceY);
        }
    }
}
