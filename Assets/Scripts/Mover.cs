using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        float moveX = Input.GetAxis("Horizontal"); // changed through controls
        float moveY = 0f;
        float moveZ = Input.GetAxis("Vertical");

        transform.Translate(moveX, moveY, moveZ);
        //transform.Translate(-moveX, -moveY, -moveZ);
    }
}
