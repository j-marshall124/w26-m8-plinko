using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public int points = 1;
    public Score score;

    public AudioSource audioSource;
    public AudioClip audioClip;
    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        audioSource.PlayOneShot(audioClip);
        score.AddPoints(points);
    }

    private void OnTriggerExit2D(Collider2D collider2d)
    {
        Destroy(collider2d.gameObject);
    }
}
