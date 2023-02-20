using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapOnBall : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        rb.AddForce(transform.forward*500f);
        rb.useGravity = true;
    }
}
