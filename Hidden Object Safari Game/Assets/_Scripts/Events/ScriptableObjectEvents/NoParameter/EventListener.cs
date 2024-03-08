using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [Tooltip("Event to subscribe to.")]
    public EventSenderSO EventSender;

    [Tooltip("Thing to do when the event is invoked. Call the desired function from this UnityEvent.")]
    public UnityEvent Response; // UnityEvents are like serialized function calls

    private void OnEnable()
    {
        EventSender.Subscribe(this);
    }
    private void OnDisable()
    {
        EventSender.Unsubscribe(this);
    }

    public void OnEventRaised()
    {
        Response?.Invoke();
    }
}
