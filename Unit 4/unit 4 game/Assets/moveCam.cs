using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public float sensativity;

    void Update()
    {
        float movement = Input.GetAxis("Mouse X");
        float xmove = movement * sensativity;
        movement = Input.GetAxis("Mouse Y");
        float ymove = movement * sensativity;
        transform.position = new Vector3(xmove, ymove, 0);
        
    }
}
