using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool isGameOver;
    public GameObject GameOverPanel;

    void Update()
    {
        if (isGameOver == true)
        {
            EndGame();
        }
        else if(isGameOver == false)
        {
            StartGame();
        }          
    }

    public void EndGame()
    {
        Time.timeScale = 0; // Freezes game
        GameOverPanel.SetActive(true); // Show Game Over menu
        isGameOver = true;
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Unfreezes game
        GameOverPanel.SetActive(false); // Hide Game Over menu
        isGameOver = false;
    }
}
