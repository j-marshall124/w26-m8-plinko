using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Rigidbody2D discRigidbody;
    public float magnitude = 5;
    public ForceMode2D forceMode = ForceMode2D.Impulse;

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            // Example random direction
            float angle = Random.Range(0, Mathf.PI * 2);
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            Vector2 force = direction * magnitude;

            // Apply force
            //discRigidbody.linearVelocity = Vector2.zero;
            discRigidbody.AddForce(force, forceMode);
        }
            
    }
}
