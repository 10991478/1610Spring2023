using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    private ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    void Start()
    {
        idObj = GetComponent<IDContainerBehavior>().idObj;
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
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
