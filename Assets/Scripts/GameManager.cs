using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartDelay = 1.0f;

    public void EndGame()
    {
        if (!GameHasEnded)
        {
            GameHasEnded = true;
            Invoke("Restart", RestartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
