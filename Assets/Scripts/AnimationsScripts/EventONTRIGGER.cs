using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventONTRIGGER : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (myEvents == null)
        {
            print("EventOnTriggerEnter was triggered but myEvents was null");
        }
        else
        {
            print("EventOnTriggerEnter Activated. Triggering" + myEvents);
            myEvents.Invoke();
        }
    }
}
