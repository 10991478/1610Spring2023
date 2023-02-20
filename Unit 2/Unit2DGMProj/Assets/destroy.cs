using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            Destroy(target);
        }
    }
}
