using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] float delay = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time > delay)
        {

            GetComponent<Rigidbody>().useGravity = true;  
        }
    }
}
