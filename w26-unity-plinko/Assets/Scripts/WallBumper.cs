using UnityEngine;

public class WallBumper : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Disc"))
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
