using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] GameObject ProjectileSet;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            ProjectileSet.SetActive(true);
    }
}
