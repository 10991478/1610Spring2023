using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineBehavior : MonoBehaviour
{
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    private float seconds = 3.0f;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        while (true)
        {
            yield return wffuObj;
            Debug.Log(":O");
        }
    }
}
