using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunIntoSomething : MonoBehaviour
{
    public GameObject boltPickUp;
    public IntObj boltCount;
    public int startingBoltCount;

    void Awake()
    {
        boltCount.setValue(startingBoltCount);
    }


    private void OnTriggerEnter(Collider other){
        if (other.gameObject.name == boltPickUp.name + "(Clone)" || other.gameObject.name == boltPickUp.name){
            boltCount.addValue(1);
            print("Bolt count is " + boltCount.value);
            Destroy(other.gameObject);
        }
    }
}
