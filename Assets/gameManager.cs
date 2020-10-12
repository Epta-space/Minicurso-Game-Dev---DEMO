using UnityEngine;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public float delayRestart = 0.9f;
    bool gameHasEnd = false;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        if (gameHasEnd == false)
        {
            gameHasEnd = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", delayRestart);
        }


    }
}

