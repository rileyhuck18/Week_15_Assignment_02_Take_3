using UnityEngine;
using TMPro; // Required for TextMeshPro UI
using System; // Required for TimeSpan to format time easily

public class GameClock : MonoBehaviour
{
    // Reference to the TextMeshPro UI element in the Inspector
    public TextMeshProUGUI timerText;

    // Variable to track the elapsed time
    private float elapsedTime;

    void Start()
    {
        // Initialize elapsed time to 0 when the game starts
        elapsedTime = 0f;
    }

    void Update()
    {
        // Increment the time by the time passed since the last frame
        elapsedTime += Time.deltaTime;

        // Update the UI text to display the formatted time
        DisplayTime(elapsedTime);
    }

    void DisplayTime(float timeToDisplay)
    {
        // Format the float time into minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        // If you want hours as well: float hours = Mathf.FloorToInt(timeToDisplay / 3600);

        // Update the text component with the formatted string (e.g., "00:00")
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
