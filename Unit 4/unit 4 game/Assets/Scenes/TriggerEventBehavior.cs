using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerClickEvent;
    public UnityEvent triggerDestroyEvent;

    public UnityEvent triggerHoldingMouseEvent;

    public void OnMouseDown(){
        triggerClickEvent.Invoke();
    }

    public void OnMouseDrag(){
        triggerHoldingMouseEvent.Invoke();
    }

    public void OnDestroy(){
        triggerDestroyEvent.Invoke();
    }
}
