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
    public IntObj boltCount;
    public int startingBoltCount;
    public FloatScriptableObject fireRate;
    public float startingFireRate;
    private float timeSinceLastShot;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //retrieving reference to GameManager script in GameManager object
        timeSinceLastShot = Time.time; //setting timeSinceLastShot to 0
        boltCount.setValue(startingBoltCount);
        fireRate.setValue(startingFireRate);
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


//shoots laser & resets timeSinceLastShot
/*CONDITIONS FOR SHOOTING:
    1: Spacebar is being pressed
    2: Game is not over
    3: The time since last shot is less than the fire rate*/
        if (Input.GetKey(KeyCode.Space) && gameManager.isGameOver == false && Time.time - timeSinceLastShot >= fireRate.value){
            ShootLaser();
            timeSinceLastShot = Time.time;
        }

    }


//shoots a different number of lasers at different angles based on boltCount IntObj object
    void ShootLaser()
    {
        switch (boltCount.value)
        {
            case 1:
                Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
                break;
            case 2:
                for (int i = -7; i <= 7; i += 14)
                {
                    Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation * Quaternion.Euler(0,i,0));
                }
                break;
            case 3:
                for (int i = -11; i <= 11; i += 11)
                {
                    Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation * Quaternion.Euler(0,i,0));
                }
                break;
            case 4:
                for (int i = -14; i <= 14; i += 7)
                {
                    Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation * Quaternion.Euler(0,i,0));
                }
                break;
            case 5:
                for (int i = -16; i <= 16; i += 8)
                {
                    Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation * Quaternion.Euler(0,i,0));
                }
                break;
            default:
                Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
                break;
        }
    }
}
