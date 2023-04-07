using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScriptActive : MonoBehaviour
{

    void OnMouseDown()
    {
        Debug.Log("Mouse down on " + gameObject.name);
        this.GetComponent<MatchBehavior>().enabled = true;
    }
    void OnMouseUp()
    {
        Debug.Log("Mouse up from " + gameObject.name);
        this.GetComponent<MatchBehavior>().enabled = false;
    }
}
