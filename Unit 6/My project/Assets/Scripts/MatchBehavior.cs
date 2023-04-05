using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    private ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    void Start()
    {
        idObj = GetComponent<IDContainerBehavior>().idObj;
    }
    private void OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>().idObj;
        if (tempID == null)
        {
            return;
        }
        ID otherID = tempID;
        if (idObj == otherID)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
