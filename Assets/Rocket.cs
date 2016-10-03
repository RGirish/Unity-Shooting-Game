using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public float speed = 20.0f;
    public float life = 5.0f;
    public float damageDealt;

    void Start() {
        Invoke("Kill", life);
    }

	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;	
	}

    void OnTriggerEnter(Collider col) {
        EnemyHealth health = col.gameObject.GetComponent<EnemyHealth>();
        if (health != null) {
            health.TakeDamage(damageDealt);
        }
        Kill();
    }
     
    void Kill() {
        Destroy(gameObject);
    }
}
