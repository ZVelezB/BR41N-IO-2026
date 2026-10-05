using UnityEngine;

public class WinningArc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 'other.transform.root' forces Unity to check the very top parent object (your PaperAirPlane) 
        // no matter which specific child part of the mesh actually touched the arc.
        if (other.transform.root.CompareTag("Player"))
        {
            FindObjectOfType<LevelTimer>().FinishLevel();
        }
    }
}