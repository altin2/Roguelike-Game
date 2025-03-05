using UnityEngine;
using TMPro; // Import for TextMeshPro

public class KillCounter : MonoBehaviour
{
    public TextMeshProUGUI killText; // Reference to the UI Text
    private int killCount = 0; // Track enemy kills
    void Awake(){
        killText.text = "Kills: " + killCount;
    }
    public void AddKill()
    {
        killCount++; // Increase kill count
        killText.text = "Kills: " + killCount; // Update UI
    }
}
