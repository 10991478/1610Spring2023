using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script constantly moves the object up
public class MoveUp : MonoBehaviour
{
    public float speed;

    void Update() //moves the object up at a constant rate
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
