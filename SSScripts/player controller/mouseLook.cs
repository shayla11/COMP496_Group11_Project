using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 400;
    public Transform playerBody;
    public bool canMoveMouse = true;

    float xRotation = 0f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Screen.lockCursor = true;


    }

    void Update()
    {
        if (canMoveMouse){
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -30f, 60f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);

        }


    }

    
}
