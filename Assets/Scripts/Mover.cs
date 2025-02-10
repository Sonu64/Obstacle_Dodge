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
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // changed through controls
        float moveY = 0f; // changed for github desktop demo
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, moveY, moveZ);
        //transform.Translate(-moveX, -moveY, -moveZ);
    }
}
