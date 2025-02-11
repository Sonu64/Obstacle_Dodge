using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        /*
         The Horizontal and Vertical issue continues wo, Faced this issue before.
         */
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; 
        float moveY = 0f; // changed for github desktop demo
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, moveY, moveZ);
        //transform.Translate(-moveX, -moveY, -moveZ);
    }
}
