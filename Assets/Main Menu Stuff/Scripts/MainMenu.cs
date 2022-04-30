using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); // Loads Level 0
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
