using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToObject : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(nameof(Teleport), other.gameObject);
    }

    private IEnumerator Teleport(GameObject other)
    {
        CharacterController characterController = other.GetComponent<CharacterController>();
        characterController.enabled = false;
        other.transform.position = _target.transform.position;
        yield return new WaitForSeconds(0.01f);
        characterController.enabled = true;
    }
}
