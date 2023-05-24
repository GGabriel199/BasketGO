using UnityEngine;

public class GetHit : MonoBehaviour
{
    public Animator anim;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.Play("Hit");
        }
    }
}
