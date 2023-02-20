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
        if (Input.GetKeyDown(KeyCode.L)){
            gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.L)){
            gameObject.SetActive(false);
        }
    }
}
