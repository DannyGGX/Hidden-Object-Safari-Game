using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjEventListener : MonoBehaviour
{
    [SerializeField] private ObjEventSenderSO _eventSender;

    [SerializeField] private UnityEvent<object> _response;
    
    private void OnEnable()
    {
        _eventSender.Subscribe(this);
    }
    private void OnDisable()
    {
        _eventSender.Unsubscribe(this);
    }

    public void OnEventRaised(object parameter)
    {
        _response.Invoke(parameter);
    }
}
