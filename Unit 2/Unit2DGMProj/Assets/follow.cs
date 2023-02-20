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
        float followSpeedX = 0f;
        float followSpeedY = 0f;
        float followSpeedZ = 0f;
        float xDiff = Math.Abs(target.transform.position.x - transform.position.x);
        float yDiff = Math.Abs(target.transform.position.x - transform.position.x);
        float zDiff = Math.Abs(target.transform.position.x - transform.position.x);
        if (xDiff > followDistance){
            followSpeedX = followSpeed*(xDiff) + minimumSpeed;
        }
        if (yDiff > followDistance){
            followSpeedY = followSpeed*(yDiff) + minimumSpeed;
        }
        if (zDiff > followDistance){
            followSpeedZ = followSpeed*(zDiff) + minimumSpeed;
        }
        if (xDiff < followDistance/2 || zDiff < followDistance/2){
            
        }
        transform.Translate(new Vector3(followSpeedX,followSpeedY,followSpeedZ) * Time.deltaTime);
    }
}
