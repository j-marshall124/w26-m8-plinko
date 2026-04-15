using UnityEngine;

public class ExamplePlayer : MonoBehaviour
{
    int health = 5;
    public void FunctionToCall()
    {
        Debug.Log("Cool function we want to call.");
        health--;
        Debug.Log(health);
    }
}
