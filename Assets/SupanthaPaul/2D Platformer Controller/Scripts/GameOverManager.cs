using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Demo");
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("StartScreen"); 
    }
}
