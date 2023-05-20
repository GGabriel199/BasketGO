using UnityEngine;
using UnityEngine.SceneManagement;

public class WatchPreview : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
