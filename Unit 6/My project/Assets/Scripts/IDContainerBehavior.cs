using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;

    void Start()
    {
        startEvent.Invoke();
    }
}
