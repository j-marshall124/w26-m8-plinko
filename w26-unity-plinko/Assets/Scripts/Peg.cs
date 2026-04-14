using Unity.Mathematics;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public int pointsLevel1 = 10;
    public int pointsLevel2 = 25;
    public int pointsLevel3 = 50;
    public Sprite unlitPeg;
    public Sprite level1Peg;
    public Sprite level2Peg;
    public Sprite level3Peg;
    private SpriteRenderer spriteRenderer;
    public Score score;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = unlitPeg;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Disc"))
        {
            if (spriteRenderer.sprite == unlitPeg)
            {
                score.AddPoints(pointsLevel1);
                spriteRenderer.sprite = level1Peg;
            }
            else if (spriteRenderer.sprite == level1Peg)
            {
                score.AddPoints(pointsLevel2);
                spriteRenderer.sprite = level2Peg;
            }
            else if (spriteRenderer.sprite == level2Peg)
            {
                score.AddPoints(pointsLevel3);
                spriteRenderer.sprite = level3Peg;
            }
        }
    }
}
