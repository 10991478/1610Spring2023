using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script makes an object constantly switch between two colors
public class PulseColor : MonoBehaviour
{
    public float speed = 1f;
    public Color mainColor;
    public Color secondaryColor;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update() // lerps the color of the object between two colors (mainColor and secondaryColor) at a speed that you can choose
    {
        float t = (Mathf.Sin(speed*Time.time - startTime));
        GetComponent<Renderer>().material.color = Color.Lerp(mainColor, secondaryColor, t);
    }
}
