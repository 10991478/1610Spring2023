//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class jumpOnClickTriggerEvent : MonoBehaviour
{
    public Vector3Data jump;
    public GameObject jumpingObject;

    public void jumpOnClick(){
        jumpingObject.GetComponent<Rigidbody>().AddForce(jump.returnVector3());
    }
}
