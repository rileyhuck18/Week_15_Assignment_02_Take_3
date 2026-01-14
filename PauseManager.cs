using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using UnityEngine.UI; // Required for UI elements like Button (if needed)

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Reference to the PauseMenuPanel
    public static bool isGamePaused = false; // Static variable to track the pause state

    void Start()
    {
        // Ensure the menu is hidden when the game starts
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
        // Ensure time scale is normal
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void Update()
    {
        // Check if the pause key (e.g., Escape) is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // Public function to resume the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Hide the pause menu UI
        Time.timeScale = 1f; // Resume normal game time
        isGamePaused = false;
        // You can also unpause the AudioListener if needed: AudioListener.pause = false;
    }

    // Public function to pause the game
    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Show the pause menu UI
        Time.timeScale = 0f; // Stop all time-based operations and physics
        isGamePaused = true;
        // You can also pause the AudioListener if needed: AudioListener.pause = true;
    }

   
    // Public function to quit the game
    public void QuitGame()
    {
        Application.Quit(); // Quits the application (works in builds, not in the editor)
    }
}
