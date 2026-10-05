using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private bool isTiming = true;

    void Update()
    {
        // If you press Space, it flips the isTiming variable (true becomes false, false becomes true)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isTiming = !isTiming;
        }

        // Only add time if we are currently timing
        if (isTiming)
        {
            currentTime += Time.deltaTime;
        }
    }

    // Call this method when the level ends (e.g., player hits a trigger or presses a button)
    public void FinishLevel()
    {
        isTiming = false;
        
        // Save the recorded time into your static variable before switching scenes
        TimerData.finalTime = currentTime; 
        
        // Load the next scene (ensure your next scene is added in Build Settings)
        SceneManager.LoadScene("WinningScene"); 
    }
}