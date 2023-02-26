//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class initializeValues : MonoBehaviour
{
    public floatData floatVal;
    public float initialFloat;
    public intData intVal;
    public int initialInt;

    void Awake(){
        floatVal.setValue(initialFloat);
        intVal.setValue(initialInt);
    }
}
