using UnityEngine;
using UnityEngine.UI; // Required for UI components if doing this via code
using System.Collections;

public class PauseManager : MonoBehaviour
{
    // A reference to your Pause Menu UI Panel (optional, but useful)
    public GameObject pauseMenuUI; 
    
    // A boolean to keep track of the game state
    public static bool GameIsPaused = false;

    void Start()
    {
        // Ensure the pause menu is hidden when the game starts
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
        ResumeGame(); // Start unpaused
    }

    // This function can be called by the Button's OnClick event
    public void TogglePauseGame()
    {
        if (GameIsPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void ResumeGame()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(false);
        }
        Time.timeScale = 1f; // Resumes the game
        GameIsPaused = false;
        // Optional: unlock and hide cursor if it was locked
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void PauseGame()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
        }
        Time.timeScale = 0f; // Pauses the game
        GameIsPaused = true;
        // Optional: show and unlock cursor so the user can click menu buttons
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
  // Public function to quit the game
    public void QuitGame()
    {
        Application.Quit(); // Quits the application (works in builds, not in the editor)
    }
}