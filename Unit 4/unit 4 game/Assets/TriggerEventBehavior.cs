using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerClickEvent;

    public void OnMouseDown(){
        triggerClickEvent.Invoke();
    }
}
