using UnityEngine;
using UnityEngine.UI;

public class DiscUI : MonoBehaviour
{
    public float disc;
    public float maxDiscs;

    public Sprite noDisc;
    public Sprite availableDisc;
    public Image[] discs; // How many discs are available    
    public DiscsAvailable discsAvailable; // Talk to the DiscsAvailable script

    void Update()
    {
        disc = discsAvailable.currentDiscs;
        maxDiscs = discsAvailable.maxDiscs;

        for (int i = 0; i < discs.Length; i++) // Loop checks how many disc are available
        {
            if (i < disc)
            {
                discs[i].sprite = availableDisc;
            }
            else
            {
                discs[i].sprite = noDisc;
            }
        }
    }
}
