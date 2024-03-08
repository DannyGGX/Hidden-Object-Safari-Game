using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventSenderSO", menuName = "Scriptable Object/Event Sender/No Parameter")]
public class EventSenderSO : ScriptableObject
{
    /// <summary>
    /// The list of listeners that this event will notify if it is raised.
    /// </summary>
    private List<EventListener> eventListeners = // List of listeners subscribed to this event. Listeners populate this array from their side
            new List<EventListener>();

    public void Invoke() // Invoke event to every listener
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--) // iterate backwards through the list
        {
            eventListeners[i].OnEventRaised();
        }
    }

    public void Subscribe(EventListener listener)
    {
        if (eventListeners.Contains(listener) == false) // Check if the list of subscribed listeners has this listener already to not add a copy
            eventListeners.Add(listener);
    }

    public void Unsubscribe(EventListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
