﻿using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Transform _playerBody;
    [SerializeField] private float _mouseSensitivity = 100f;

    private float _xRotation = 0f;

    private void Start()
    { 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);

        _playerBody.Rotate(Vector3.up * mouseX);
    }
}
