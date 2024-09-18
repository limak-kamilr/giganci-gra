using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float mouseSensitivity = 300f;
    Transform playerBody;
    float xRotation, yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.localRotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
