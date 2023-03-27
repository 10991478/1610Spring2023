using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunIntoSomething : MonoBehaviour
{
    public GameObject boltPickup;
    public IntObj boltCount;
    public GameObject boltPickupText;
    public GameObject fireRatePickup;
    public FloatScriptableObject fireRate;
    public GameObject fireRateText;
    public GameObject pointPickup;
    private ScoreManager scoreManager;
    public int pickupReward;
    public GameObject pointPickupText;

    void Awake(){
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //finds ScoreManager GameObject to reference its ScoreManager script component
    }

    private void OnTriggerEnter(Collider other){
//if the objet is a boltpickup object, add 1 to the bolt count and destroy the pickup
        if (other.gameObject.name == boltPickup.name + "(Clone)" || other.gameObject.name == boltPickup.name)
        {
            boltCount.addValue(1);
            Instantiate(boltPickupText,transform.position,Quaternion.Euler(90,0,0));
            Destroy(other.gameObject);
        }
//if the object is a fireRatePickup object, decrease FireRate (decreases the time between shots) and destroy the pickup
        else if (other.gameObject.name == fireRatePickup.name + "(Clone)" || other.gameObject.name == fireRatePickup.name)
        {
            fireRate.addValue(-0.1f);
            Instantiate(fireRateText,transform.position,Quaternion.Euler(90,0,0));
            Destroy(other.gameObject);
        }
//if the object is a pointPickup object, increase the score
        else if (other.gameObject.name == pointPickup.name + "(Clone)" || other.gameObject.name == pointPickup.name)
        {
            scoreManager.IncreaseScore(pickupReward);
            GameObject text = Instantiate(pointPickupText,transform.position,Quaternion.Euler(90,0,0));
            text.GetComponent<TextMesh>().text = "+ " + pickupReward + " points";
            Destroy(other.gameObject);
        }
    }
}
