using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunIntoSomething : MonoBehaviour
{
    public GameObject boltPickup;
    public IntObj boltCount;
    public int startingBoltCount;
    public GameObject fireRatePickup;

    void Awake()
    {
        boltCount.setValue(startingBoltCount);
    }


    private void OnTriggerEnter(Collider other){
//if the objet is a boltpickup object, add 1 to the bolt count and destroy the pickup
        if (other.gameObject.name == boltPickup.name + "(Clone)" || other.gameObject.name == boltPickup.name)
        {
            boltCount.addValue(1);
            print("Bolt count is " + boltCount.value);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name == fireRatePickup.name + "(Clone)" || other.gameObject.name == fireRatePickup.name)
        {
            print("Increased fire rate!");
            Destroy(other.gameObject);
        }
    }
}
