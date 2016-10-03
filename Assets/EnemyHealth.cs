using UnityEngine;
using System.Collections;
 
public class EnemyHealth : MonoBehaviour {
 
    public float initialHealth = 10.0f;
    private float currentHealth;
 
    void Start () {
        currentHealth = initialHealth;
    }
 
    public void TakeDamage(float damage) {
        currentHealth -= damage; 
        if (currentHealth < 0) {
            Destroy(gameObject);
        }
    }
}