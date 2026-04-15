using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Plinko"); // Reloads the Plinko scene
    }
}
