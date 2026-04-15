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
    public DiscsAvailable discsAvailable;
    public GameOver gameOver;

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
        if (discsAvailable.currentDiscs > 0) // If there are discs available
        {
            // Drop disc
            if (Input.GetKeyDown(KeyCode.Space) && currentDisc == null)
            {
                // Clone prefab
                currentDisc = Instantiate(discPrefab, transform.position, Quaternion.identity);
                spriteRenderer.sprite = noDisc;
                // Set camera to follow this
                cameraFollow.FollowTarget(currentDisc.transform);

                gameObject.GetComponent<DiscsAvailable>().NumberOfDiscs(-1); // Remove one available disc
            }
            else if (currentDisc == null)
            {
                spriteRenderer.sprite = haveDisc;
            }
        }
        else if (discsAvailable.currentDiscs <= 0) // If no discs are available
        {
            if (currentDisc == null)
            {
                gameOver.isGameOver = true; // Game Over screen
            }
        }
    }
}
