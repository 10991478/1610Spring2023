using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeInactiveL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -3 || transform.position.x > 3 || transform.position.z < -3 || transform.position.z > 3){
            gameObject.SetActive(false);
        }
    }
}
