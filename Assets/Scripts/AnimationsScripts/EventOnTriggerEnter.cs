using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTriggerEnter : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(myEvents == null)
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
