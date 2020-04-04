using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameSession = false;
    bool GameHasEnded = false;

    public float RestartDelay = 1.0f;

    public static int[] Score = {0, 0};
    public Text ScoreText;

    public void EndGame(string Winner)
    {
        if (!GameHasEnded)
        {
            GameHasEnded = true;

            if (Winner == "Player_1") Score[0]++;
            else Score[1]++;
            Invoke("Restart", RestartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreText.text = $"{Score[0]} : {Score[1]}";
    }
}
