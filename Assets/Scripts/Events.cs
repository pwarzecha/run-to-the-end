using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

        public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PauseGame()
    {
        PlayerManager.isGamePaused = true;
    }

    public void ResumeGame()
    {
        PlayerManager.isGamePaused = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void TurnOnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
