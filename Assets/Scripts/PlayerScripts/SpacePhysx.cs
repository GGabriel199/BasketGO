using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePhysx : MonoBehaviour
{
    public Rigidbody2D rb;
    public CircleCollider2D col;

    public Vector2 pos { get { return transform.position; } }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
    }

    public void Push(Vector2 force)
    {
        rb.AddForce(force, ForceMode2D.Impulse);
    }

    public void ActivateRb()
    {
        rb.isKinematic = false;
    }

    public void DesactivateRb()
    {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }
}
