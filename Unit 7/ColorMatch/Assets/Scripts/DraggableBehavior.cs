using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    public bool everythingFrozen;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;

    void Awake()
    {
        cameraObj = Camera.main;
        everythingFrozen = false;
    }

    public IEnumerator OnMouseDown()
    {
        if (!everythingFrozen)
        {
            offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
            draggable = true;
            startDragEvent.Invoke();
            yield return new WaitForFixedUpdate();

            while (draggable & !everythingFrozen)
            {
                yield return new WaitForFixedUpdate();
                position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
                transform.position = position;
            }
        }
    }

    void OnMouseUp()
    {
        if (!everythingFrozen)
        {
            draggable = false;
            endDragEvent.Invoke();
        }
    }
}
