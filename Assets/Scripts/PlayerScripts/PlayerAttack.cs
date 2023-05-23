using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<EnemyHealth>().health -= 40;
            FindObjectOfType<SoundManager>().Play("HitPlane");
        }
    }
}