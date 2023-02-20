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
        if (target.transform.position.x - transform.position.x > Math.Abs(followDistance)){
            followSpeedX = followSpeed*(Math.Abs(target.transform.position.x - transform.position.x)) + minimumSpeed;
        }
        if (target.transform.position.y - transform.position.y > Math.Abs(followDistance)){
            followSpeedY = followSpeed*(Math.Abs(target.transform.position.y - transform.position.y)) + minimumSpeed;
        }
        if (target.transform.position.z - transform.position.z > Math.Abs(followDistance)){
            followSpeedZ = followSpeed*(Math.Abs(target.transform.position.z - transform.position.z)) + minimumSpeed;
        }
        transform.Translate(new Vector3(followSpeedX,followSpeedY,followSpeedZ));
    }
}
