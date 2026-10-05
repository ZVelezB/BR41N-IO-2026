using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI resultText; 

    void Start()
    {
        // Calculate minutes, seconds, and hundredths of a second
        int minutes = Mathf.FloorToInt(TimerData.finalTime / 60);
        int seconds = Mathf.FloorToInt(TimerData.finalTime % 60);
        int fraction = Mathf.FloorToInt((TimerData.finalTime % 1) * 100);

        // Format the string to look like MM:SS.ms (e.g., 01:24.53)
        string formattedTime = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, fraction);

        resultText.text = "Congratulations! Your time was: " + formattedTime;
    }
}