using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script constantly moves the object forward
public class MoveForward : MonoBehaviour
{
    public float speed;

    void Update() //moves the object forward at a constant rate
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}