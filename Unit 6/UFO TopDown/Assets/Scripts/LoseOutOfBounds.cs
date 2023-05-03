using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for losing the game when the object goes below the lowerbound
public class LoseOutOfBounds : MonoBehaviour
{
    public float upperBound = 20.0f;
    public float lowerBound = -10.0f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
// if the object is above the upperBound, it will be destroyed
// if the object is below the lowerBound, it will be destroyed and gameManager.isGameOver will be set to true
        if (transform.position.z > upperBound){
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound){
            Debug.Log("Game over!");
            gameManager.isGameOver = true;
            Destroy(gameObject);
        }
    }
}
