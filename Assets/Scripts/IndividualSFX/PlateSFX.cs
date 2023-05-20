using UnityEngine;
using UnityEngine.Audio;

public class PlateSFX : MonoBehaviour
{
    private EdgeCollider2D plate;

    private void Awake()
    {
        plate = GetComponent<EdgeCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            FindObjectOfType<SoundManager>().Play("BallHitplate");
        }
    }
}
