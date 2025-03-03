using UnityEngine;

public class ObjectHit : MonoBehaviour {

    // Caching
    MeshRenderer obstacleMesh;

    private void Start() {
        obstacleMesh = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision) {
        // Only change color of obstacle if the Player has collided
        // collision.gameObject refers to Player
        // gameObject refers to current Object, i.e - Individual Obstacles
        if (collision.gameObject.tag == "Player") {
            obstacleMesh.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
