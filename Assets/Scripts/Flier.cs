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
        GoToPlayer();
        DestroyWhenReached();
    }


    void GoToPlayer() { 
        /**
         * the reason we need to specify Vector3 before MoveTowards is because MoveTowards is 
         * a static method of the Vector3 struct. There isn't a standalone MoveTowards() function
         * —it's specifically part of Vector3 (or Vector2 for 2D).
         * 
        **/

        // We are not following Player, when we reach playerPosition we stop. This is because
        // playerPosition is initialized in Start()
        transform.position = 
            Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }

    void DestroyWhenReached() {
        if (transform.position == playerPosition)
            Destroy(gameObject);
    }
}
