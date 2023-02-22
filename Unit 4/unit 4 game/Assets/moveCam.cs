using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public float sensativity;
    public GameObject target;

    void Update()
    {
        float movement = Input.GetAxis("Mouse X");
        float xmove = movement * sensativity;
        movement = Input.GetAxis("Mouse Y");
        float ymove = movement * sensativity;
        transform.RotateAround(target.transform.position, Vector3.up, xmove * Time.deltaTime * sensativity);
        transform.RotateAround(Vector.zero, transform.right, ymove * Time.deltaTime * sensativity);
        
    }
}
