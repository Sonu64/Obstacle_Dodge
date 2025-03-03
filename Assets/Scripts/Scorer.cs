using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numberOfHits = 0; // the Plane is also a default collision with a collider
    
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag != "Hit") {
            numberOfHits = numberOfHits + 1; // being called twice if Capsule collider is On on Ducky
            Debug.Log("You have hit " + numberOfHits + " times !");
        }
    }
}
