using UnityEngine;

public class TunnelLevelFinished : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player")){
            Level10EventAnalytics.OnEventCall();
            Debug.Log("tunel level complete");
        }
    }
}
