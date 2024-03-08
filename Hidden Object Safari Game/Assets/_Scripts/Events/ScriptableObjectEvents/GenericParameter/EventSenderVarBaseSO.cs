using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventSenderVarBaseSO<T> : ScriptableObject
{
    private List<EventListenerVar<T>> eventListeners = new List<EventListenerVar<T>>();

    public void Invoke(T parameter)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(parameter);
        }
    }
    
    public void Subscribe(EventListenerVar<T> listener)
    {
        if (eventListeners.Contains(listener) == false) // Check if the list of subscribed listeners has this listener already to not add a copy
            eventListeners.Add(listener);
    }

    public void Unsubscribe(EventListenerVar<T> listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
