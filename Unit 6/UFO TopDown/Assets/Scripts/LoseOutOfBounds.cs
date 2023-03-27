using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
