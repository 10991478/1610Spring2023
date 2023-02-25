using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMined : MonoBehaviour
{
    float initialHealth;
    float health;
    public float mineRate;
    public floatData energy;

    void Awake(){
        initialHealth = 15;
        health = initialHealth;
    }
    void OnMouseDrag()
    {
        if (energy.value - energy.decayRate > 0){
            health -= mineRate;
        }
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    void OnMouseUp(){
        health = initialHealth;
    }
}
