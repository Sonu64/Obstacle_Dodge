using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] GameObject ProjectileSet;


    // Awake() is called whenever gameObject is activated for the 1st time. Not 
    // when game starts. If we use Start() here, and the player manages not to go through
    // Trigger volume, then still Projectiles will fly to Starting Player Position and not
    // new Player Position.
    // UNITY ORDER OF EXECUTION -> Awake() -> OnEnable() -> Reset() -> Start() for a gameObject.
    private void Awake() {
        ProjectileSet.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            ProjectileSet.SetActive(true);
    }
}
