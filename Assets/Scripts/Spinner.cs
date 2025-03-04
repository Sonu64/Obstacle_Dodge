using UnityEngine;

public class Spinner : MonoBehaviour {

    [SerializeField] float rotateX = 0;
    [SerializeField] float rotateY = 0;
    [SerializeField] float rotateZ = 0;
    [SerializeField] float rotateSpeed = 0;
    
    void Start() {
        
    }

    void Update() {
        transform.Rotate(rotateSpeed * rotateX, rotateSpeed * rotateY, rotateSpeed * rotateZ);
    }
}
