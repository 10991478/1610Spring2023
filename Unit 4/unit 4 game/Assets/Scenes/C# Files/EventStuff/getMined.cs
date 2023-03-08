using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class getMined : MonoBehaviour
{
    public float initialHealth;
    float health;
    public float mineRate;
    public floatData energy;
    public UnityEvent healthDepleated;

    void Awake(){
        health = initialHealth;
    }
    void OnMouseDrag()
    {
        if (energy.value - energy.decayRate > 0){
            health -= mineRate;
        }
        if (health <= 0){
            healthDepleated.Invoke();
            Destroy(gameObject);
        }
    }

    void OnMouseUp(){
        health = initialHealth;
    }
}
