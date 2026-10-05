using UnityEngine;
using TMPro; // Required for TextMeshPro

public class TimeDisplay : MonoBehaviour
{
    // Drag your TextMeshPro element into this slot in the Unity Inspector
    public TextMeshProUGUI resultText; 

    void Start()
    {
        // Read the time from the static class and format it to 2 decimal places ("F2")
        resultText.text = "Congratulations! Your time was: " + TimerData.finalTime.ToString("F2");
    }
}