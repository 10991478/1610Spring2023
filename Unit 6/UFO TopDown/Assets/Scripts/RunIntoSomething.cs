using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunIntoSomething : MonoBehaviour
{
    public GameObject damagePowerUp;
    public FloatScriptableObject damage;
    public float startingDamageLevel;
    public float damageIncrease;

    private void Awake(){
        damage.setValue(startingDamageLevel);
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.name == damagePowerUp.name + "(Clone)" || other.gameObject.name == damagePowerUp.name){
            damage.addValue(damageIncrease);
            print("Damage level is " + damage.value);
            Destroy(other.gameObject);
        }
    }
}
