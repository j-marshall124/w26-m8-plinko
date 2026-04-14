using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float maxHorizontalX = 5;
    public float speed = 5f;
    public CameraFollow cameraFollow;
    public GameObject discPrefab;
    private GameObject currentDisc = null;
    public Sprite noDisc;
    public Sprite haveDisc;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        // Move player horizontally
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 position = transform.position;
        position.x += moveX;
        position.x = Mathf.Clamp(position.x,-maxHorizontalX, +maxHorizontalX);
        transform.position = position;        
    }

    void Update()
    {        
        // Drop disc
        if (Input.GetKeyDown(KeyCode.Space) && currentDisc == null)
        {
            // Clone prefab
            currentDisc = Instantiate(discPrefab, transform.position, Quaternion.identity);
            spriteRenderer.sprite = noDisc;
            // Set camera to follow this
            cameraFollow.FollowTarget(currentDisc.transform);
        }
        else if (currentDisc == null)
        {
            spriteRenderer.sprite = haveDisc;
        }
    }
}
