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
<<<<<<< HEAD
        float xDist = target.transform.position.x - transform.position.x;
        float yDist = target.transform.position.y - transform.position.y;
        float zDist = target.transform.position.z - transform.position.z;
        if (Math.Abs(xDist) > followDistance){
            followX = followSpeed*(xDist) + minimumSpeed;
            print("x too far");
        }
        if (Math.Abs(zDist) > followDistance){
            followZ = followSpeed*(zDist) + minimumSpeed;
            print("z too far");
        }
        if (Math.Abs(yDist) > followDistance){
            followY = followSpeed*(yDist) + minimumSpeed;
            print("y too far");
        }
        
=======
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
>>>>>>> main
        transform.Translate(new Vector3(followX,followY,followZ) * Time.deltaTime);
    }
}
