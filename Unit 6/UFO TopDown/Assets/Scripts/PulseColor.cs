using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseColor : MonoBehaviour
{
    public float speed = 1f;
    public Color mainColor;
    public Color secondaryColor;
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = (Mathf.Sin(speed*Time.time - startTime));
        GetComponent<Renderer>().material.color = Color.Lerp(mainColor, secondaryColor, t);
    }
}
