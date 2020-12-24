using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public float restartDelay = 1f;

    public GameObject ui;

    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void WinGame()
    {
        ui.SetActive(true);
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
