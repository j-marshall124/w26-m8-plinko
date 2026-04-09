using UnityEngine;

public class ExampleEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ExamplePlayer player = collision.gameObject.GetComponent<ExamplePlayer>();
        if (player != null )
        {
            player.FunctionToCall();
        }
    }
}
