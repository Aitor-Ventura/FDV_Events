using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    void Update()
    {
        if (Vector3.Distance(transform.position, _target.position) < 2f && _target.gameObject.CompareTag("Player"))
        { 
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _target.position, 5f * Time.deltaTime);
    }
}
