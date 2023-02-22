using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    


    void Update()
    {
        float movement = Input.GetAxis("Mouse X");
        if (movement < 0){
            print("moved mouse left");
        }
        if (movement > 0 ){
            print("moved mouse right");
        }
    }
}
