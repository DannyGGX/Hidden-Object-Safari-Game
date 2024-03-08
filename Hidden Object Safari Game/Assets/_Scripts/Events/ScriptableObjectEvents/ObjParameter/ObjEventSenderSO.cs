using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjEventSenderSO", menuName = "Scriptable Object/Event/object Parameter")]
public class ObjEventSenderSO : ScriptableObject
{
    private List<ObjEventListener> eventListeners = new List<ObjEventListener>();

    public void Invoke(object parameter)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(parameter);
        }
    }
    
    public void Subscribe(ObjEventListener listener)
    {
        if (eventListeners.Contains(listener) == false) // Check if the list of subscribed listeners has this listener already to not add a copy
            eventListeners.Add(listener);
    }

    public void Unsubscribe(ObjEventListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
