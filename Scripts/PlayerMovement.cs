using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private CharacterController _controller;

    private void Start()
    {
        _controller = gameObject.AddComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), -1f, Input.GetAxis("Vertical"));
        _controller.Move(move * (speed * Time.deltaTime));
    }

    public void SetSpeed(float setSpeed)
    {
        speed = setSpeed;
    }
}
