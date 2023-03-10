using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 25;
    private float horizontalInput;
    public float xbound = 25;
    public Transform blaster;
    public GameObject laserBolt;
    
    void Update()
    {

//sideways movement + borders
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -xbound){
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xbound){
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }

//shooting the lazer
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

    }
}
