using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
/*When playing the game, the z axis is the axis running up and down the screen.
If the GameObject this script is attached to moves to a z position out of the bounds set by upperBound and lowerBound, it is destroyed*/
    public float upperBound = 20.0f;
    public float lowerBound = -10.0f;
    void Update()
    {
        if (transform.position.z > upperBound || transform.position.z < lowerBound){
            Destroy(gameObject);
        }
    }
}
