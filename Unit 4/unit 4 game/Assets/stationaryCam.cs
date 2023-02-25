using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stationaryCam : MonoBehaviour
{
    public GameObject target;
    public float camHeight;
    public bool followTarget;

    void Awake(){
        transform.position = new Vector3(0,camHeight,0);
    }
    void FixedUpdate()
    {
        if (followTarget){
            transform.LookAt(target.transform.position);
        }
    }
}
