using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // For TextMeshPro UI component

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 Instance; // Singleton to allow global access to GameManager1

    private int score = 0; // Keeps track of the player's score

    [SerializeField] private TextMeshProUGUI scoreText; // Reference to the TextMeshPro text on the scoreboard

    private void Awake()
    {
        // Ensure there's only one GameManager1 instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initialize the scoreboard with the starting score
        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        // Increment the score by the specified points
        score += points;

        // Update the scoreboard UI
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        // Update the TextMeshPro text to display the current score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("Score Text is not assigned in the GameManager1!");
        }
    }
}