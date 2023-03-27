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
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {

//sideways movement + borders
    //translating based on getaxis input. moves left/right when a/left button pressed and d/right button pressed
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

    //setting left and right boundaries so player can't pass that
        if (transform.position.x < -xbound){
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xbound){
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }

//shooting the laser
    //instatiating a laser when spacebar is pressed if game is still running
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false ){
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

    }
}
