using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperBound = 20.0f;
    public float lowerBound = -10.0f;
    void Update()
    {
        if (transform.position.z > upperBound){
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound){
            if (gameObject.name != "DamagePowerUp")
            {
                print("Game over!");
                Time.timeScale = 0;
            }
            Destroy(gameObject);
        }
    }
}
