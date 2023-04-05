using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScriptActive : MonoBehaviour
{

    void OnMouseDrag()
    {
        GetComponent<MatchBehavior>().enabled = true;
    }
    void OnMouseExit()
    {
        GetComponent<MatchBehavior>().enabled = false;
    }
}
