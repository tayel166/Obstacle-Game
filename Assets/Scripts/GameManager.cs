using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnd = false;
    public float RestartDelay = 1f;
    public GameObject completeLevel;

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }
    public void GameOver()
    {
        if(GameEnd == false)
        {
            GameEnd = true;
            Debug.Log("Game over");
            Invoke("Restart",RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
