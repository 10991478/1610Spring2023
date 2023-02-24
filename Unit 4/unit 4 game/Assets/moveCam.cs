using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public float sensativity;
    public float followDistance;
    public GameObject target;

    void Update()
    {
        transform.LookAt(target.transform.position);
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > followDistance){
            transform.Translate(Vector3.forward * dist * Time.deltaTime);
        }
        float movement = Input.GetAxis("Mouse X");
        float xmove = movement * sensativity;
        movement = Input.GetAxis("Mouse Y");
        float ymove = movement * sensativity;
        transform.RotateAround(target.transform.position, Vector3.left, ymove * Time.deltaTime * sensativity);
        transform.RotateAround(target.transform.position, Vector3.up, xmove * Time.deltaTime * sensativity);
    }
}
