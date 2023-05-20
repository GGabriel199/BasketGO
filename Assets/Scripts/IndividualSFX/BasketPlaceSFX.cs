using UnityEngine;
using UnityEngine.Audio;

public class BasketPlaceSFX : MonoBehaviour
{
    private EdgeCollider2D basket;

    private void Awake()
    {
        basket = GetComponent<EdgeCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            FindObjectOfType<SoundManager>().Play("BallHitplate");
        }
    }
}
