using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numberOfHits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        numberOfHits = numberOfHits + 1; // being called twice if Capsule collider is On on Ducky
        Debug.Log("You have hit " + numberOfHits + " times !");
    }
}
