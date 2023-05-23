using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<SoundManager>().Play("ClickOut");
            other.gameObject.GetComponent<PlayerHealth>().health = 100;
            Destroy(gameObject);
        }
    }
}
