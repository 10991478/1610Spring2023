using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Time.time - startTime >= timeBeforeDestruction)
        {
            Destroy(gameObject);
        }
    }
}
