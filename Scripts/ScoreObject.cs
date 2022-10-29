using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreObject : MonoBehaviour
{
    public UnityEvent addScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            addScore?.Invoke();
        }
    }
}
