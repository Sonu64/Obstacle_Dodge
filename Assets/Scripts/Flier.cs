using Unity.VisualScripting;
using UnityEngine;

public class Flier : MonoBehaviour {

    [SerializeField] float flySpeed = 0.1f;
    [SerializeField] Transform player;



    // Can't initialize it's value
    // yet as Game hasn't started and player.transform.position
    // doesn't exist
    Vector3 playerPosition; 



    void Start() {
        // Initialize playerPosition here, just when the game starts. We don't need 
        // the Flier to follow the Player !! Mind it !!
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update() {
        /** Working with Ducky's body only !! WHY ? **/
        transform.position = 
            Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }
}
