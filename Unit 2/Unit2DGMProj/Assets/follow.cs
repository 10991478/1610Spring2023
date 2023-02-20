using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    public float followDistance = 2.0f;
    public float followSpeed = 0.5f;
    public float minimumSpeed = 0.5f;

    void Update()
    {
        float followX = 0f;
        float followY = 0f;
        float followZ = 0f;
        float xDiff = Math.Abs(target.transform.position.x - transform.position.x);
        float yDiff = Math.Abs(target.transform.position.y - transform.position.y);
        float zDiff = Math.Abs(target.transform.position.z - transform.position.z);
        if (xDiff > followDistance){
            followX = followSpeed*(xDiff) + minimumSpeed;
        }
        if (zDiff > followDistance){
            followZ = followSpeed*(zDiff) + minimumSpeed;
        }
        if (xDiff < followDistance/2 && zDiff < followDistance/2){
            followY = 2*followDistance*(1/(1+xDiff*xDiff+zDiff*zDiff));
        }
        else if (yDiff > followDistance){
            followY = followSpeed*(yDiff) + minimumSpeed;
        }
        transform.Translate(new Vector3(followX,followY,followZ) * Time.deltaTime);
    }
}
