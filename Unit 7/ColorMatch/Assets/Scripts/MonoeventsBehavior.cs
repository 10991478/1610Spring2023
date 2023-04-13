using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoeventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, destroyEvent;

    void Start()
    {
        startEvent.Invoke();
    }

    void Awake()
    {
        awakeEvent.Invoke();
    }

    void Destroy()
    {
        destroyEvent.Invoke();
    }
}
