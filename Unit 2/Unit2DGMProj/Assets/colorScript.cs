using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{
    int cubeScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Your score is "+cubeScore);
        cubeScore += 5;
        Debug.Log("Your score increased by 5. Your score is now "+cubeScore);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G)){
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B)){
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (transform.position.y > 2 && transform.position.y < 3){
            GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("Passed through yellow zone");
        }
        if (Input.GetKeyDown(KeyCode.Down)){
            cubeScore = addToScore(cubeScore, -1);
            Debug.Log("Score: "+cubeScore);
        }
        if (Input.GetKeyDown(KeyCode.Up)){
            cubeScore = addToScore(cubeScore, 1);
            Debug.Log("Score: "+cubeScore);
        }
    }

    int addToScore(int score, int n){
        score += n;
        return score;
    }
}
