using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunIntoSomething : MonoBehaviour
{
    public GameObject boltPickup;
    public IntObj boltCount;
    public GameObject fireRatePickup;
    public FloatScriptableObject fireRate;


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
            fireRate.addValue(-0.1f);
            print("Fire rate is " + fireRate.value);
            Destroy(other.gameObject);
        }
    }
}
