using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script destroys the object after a certain amount of time after starting
public class TimedDestruction : MonoBehaviour
{

    public float timeBeforeDestruction;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        if (Time.time - startTime >= timeBeforeDestruction) //destroys the object is it's existed as long or longer than timeBeforeDestruction
        {
            Destroy(gameObject);
        }
    }
}
