using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetManager : MonoBehaviour
{
    public void PlayAgain()
    {
        // 1. This prints a message to your Unity Console to prove the button works
        Debug.Log("THE RESET BUTTON WAS SUCCESSFULLY CLICKED!"); 
        
        TimerData.finalTime = 0f; 
        
        // 2. Load the main game scene again
        SceneManager.LoadScene("JogoScreen");
    }
}