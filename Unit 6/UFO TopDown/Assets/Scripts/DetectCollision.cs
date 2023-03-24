using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject[] doDetect;
    void OnTriggerEnter(Collider other)
    {
        bool detect = false;
        foreach (GameObject item in doDetect){
            if (other.gameObject.name == item.name + "(Clone)" || other.gameObject.name == item.name) //only detects the gameObject if it's a clone of any gameObjects in the doDetect list
            {
                detect = true;
                break;
            };
        }
        if (detect)
        {
            Destroy(other.gameObject); //Destroys this object
            Destroy(gameObject); //Destroys the other object
        }
    }
}
