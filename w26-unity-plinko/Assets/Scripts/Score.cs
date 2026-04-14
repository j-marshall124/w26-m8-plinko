using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int totalScore = 0;
    public TMP_Text scoreDisplay;

    private void Start()
    {
        // Update UI
        AddPoints(0);
    }

    public void AddPoints(int points)
    {
        totalScore += points;
        scoreDisplay.text = $"SCORE: {totalScore}";
    }
}
