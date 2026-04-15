using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int totalScore = 0;
    public TMP_Text scoreDisplay;
    public TMP_Text scoreDisplayEnd;

    private void Start()
    {
        // Update UI
        AddPoints(0);
    }

    public void AddPoints(int points)
    {
        totalScore += points;
        scoreDisplay.text = $"SCORE: {totalScore}"; // Displays score during gameplay
        scoreDisplayEnd.text = $"SCORE: {totalScore}"; // Displays score when game is over
    }
}
