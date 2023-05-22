using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollider : MonoBehaviour
{
    public Animator anim;
    public float lostHealth;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<SoundManager>().Play("Seagull");
            other.gameObject.GetComponent<PlayerHealth>().health -= lostHealth;
            anim.Play("Destruction");
            Destroy(gameObject, anim.GetCurrentAnimatorStateInfo(0).length);
        }
    }
}
