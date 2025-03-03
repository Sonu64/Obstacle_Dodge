using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour {

    [SerializeField] float delay = 5.0f;

    //Caching References for current object
    Rigidbody myRigidBody;
    MeshRenderer myMeshRenderer;
    
    void Start() {
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer = myRigidBody.GetComponent<MeshRenderer>();
    }

    void Update() {
        if (Time.time > delay) {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
