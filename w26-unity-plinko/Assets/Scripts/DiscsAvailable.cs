using UnityEngine;

public class DiscsAvailable : MonoBehaviour
{
    public float currentDiscs;
    public float maxDiscs;
    public Sprite noDisc;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void NumberOfDiscs(float amount)
    {
        currentDiscs += amount;

        if (currentDiscs <= 0)
        {
            spriteRenderer.sprite = noDisc; // Shows player sprite with no disc available
        }
    }
}
