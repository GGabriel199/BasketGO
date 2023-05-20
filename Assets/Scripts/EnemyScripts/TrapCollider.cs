using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollider : MonoBehaviour
{
    public Animation anim;
    public float lostHealth;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= lostHealth;
            Destroy(gameObject, .21f);
            anim.Play("Destruction");
        }
    }
}
