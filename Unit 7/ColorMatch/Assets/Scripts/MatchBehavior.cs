using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public Vector3 defaultPosition;
    public UnityEvent matchEvent, matchDelayedEvent, noMatchEvent, noMatchDelayedEvent;
    private WaitForSeconds wfsObj;

    void Start()
    {
        wfsObj = new WaitForSeconds(0.05f);
        UpdateIDObj();
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>().idObj;
        if (tempID == null)
        {
            yield break;
        }
        ID otherID = tempID;
        if (idObj == otherID)
        {
            matchEvent.Invoke();
            yield return wfsObj;
            matchDelayedEvent.Invoke();

        }
        else
        {
            noMatchEvent.Invoke();
            yield return wfsObj;
            noMatchDelayedEvent.Invoke();
        }
    }

    public void ResetPosition()
    {
        gameObject.transform.position = defaultPosition;
    }

    public void UpdateIDObj()
    {
        idObj = GetComponent<IDContainerBehavior>().idObj;
    }
}
