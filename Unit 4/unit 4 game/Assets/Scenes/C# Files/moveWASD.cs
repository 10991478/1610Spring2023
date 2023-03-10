using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWASD : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float turnSpeed = 50.0f;
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}