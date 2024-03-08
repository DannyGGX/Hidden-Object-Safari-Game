using UnityEngine;
using UnityEngine.Events;

public class EventListenerVar<T> : MonoBehaviour
{
    [SerializeField] private EventSenderVarBaseSO<T> _eventSender;

    [SerializeField] private UnityEvent<T> _response;
    
    private void OnEnable()
    {
        _eventSender.Subscribe(this);
    }
    private void OnDisable()
    {
        _eventSender.Unsubscribe(this);
    }

    public void OnEventRaised(T parameter)
    {
        _response.Invoke(parameter);
    }
}
