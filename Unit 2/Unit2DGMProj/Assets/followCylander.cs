using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCylander : MonoBehaviour
{
    void Awake(){
        transform.position.y = 6;
        transform.position.x = 3;
        transform.position.z = 2;
        print("position set");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(character.transform.position.y < transform.position.y - 1){
            transform.position.y -= .2;
        }
        else if (character.transform.position.y > transform.position.y + 1){
            transform.position.y += .2;
        }
    }
}
