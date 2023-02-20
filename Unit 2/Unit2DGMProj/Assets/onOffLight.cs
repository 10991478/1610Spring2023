using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOffLight : MonoBehaviour
{
    private Light lulu;
    // Start is called before the first frame update
    void Start()
    {
        lulu = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)){
            lulu.enabled = !lulu.enabled;
            if (lulu.enabled){
                print("light is on");
            }
            else {
                print("light is off");
            }
        }
    }
}
