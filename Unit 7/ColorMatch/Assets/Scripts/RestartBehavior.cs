using UnityEngine;
using UnityEngine.Events;

public class RestartBehavior : MonoBehaviour
{
    public UnityEvent restartEvent;

    public void RestartGame()
    {
        gameObject.transform.position = Vector3.zero;
        GetComponent<DraggableBehavior>().everythingFrozen = false;
        restartEvent.Invoke();
    }
}