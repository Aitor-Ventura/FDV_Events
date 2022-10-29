using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GateTrigger : MonoBehaviour
{
    public UnityEvent MoveGate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MoveGate?.Invoke();    
        }
    }
}
