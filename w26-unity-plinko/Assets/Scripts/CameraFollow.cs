using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    public Transform player;
    public float lerpSpeed = 0.3f;
    public float cameraY = 10;

    void FixedUpdate()
    {
        // Temp of where camera is
        Vector3 position = this.transform.position;

        // Follow target if they exist
        if (followTarget != null)
        {
            position.x = followTarget.position.x;
            //position.y = followTarget.position.y - cameraY;  
        }
        // Else look at player
        else
        {
            position.x = player.position.x;
            position.y = player.position.y - cameraY;
            if (position.x > 5)
            {
                position.x = followTarget.position.x;
            }
            else if (position.x < -5)
            {
                position.x = followTarget.position.x;
            }
        }

        // Assign new coordinates back to camera
        this.transform.position = Vector3.Lerp(this.transform.position, position, lerpSpeed);
    }

    public void FollowTarget(Transform target)
    {
        followTarget = target;
    }
}
