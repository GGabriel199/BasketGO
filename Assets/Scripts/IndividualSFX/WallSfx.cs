using UnityEngine;
using UnityEngine.Audio;

public class WallSfx : MonoBehaviour
{
    private EdgeCollider2D wall;

    private void Awake()
    {
        wall = GetComponent<EdgeCollider2D>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            FindObjectOfType<SoundManager>().Play("BallHitWall");
        }
    }
}
