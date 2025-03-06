using UnityEngine;
using TMPro; // Import for TextMeshPro

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI LevelText; // Reference to the UI Text
    [SerializeField] private Player player;
    void Awake(){
        player = FindObjectOfType<Player>();
        LevelText.text = "Level: " + player.PlayerLevel;
        
    }
    public void UpdateText()
    {
        LevelText.text = "Level: " + player.PlayerLevel; // Update UI
    }
}
