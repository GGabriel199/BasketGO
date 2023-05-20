using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSFX : MonoBehaviour
{
    public string sfxCol, sfxTrg;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<SoundManager>().Play(sfxCol);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<SoundManager>().Play(sfxTrg);
        }
    }
}
