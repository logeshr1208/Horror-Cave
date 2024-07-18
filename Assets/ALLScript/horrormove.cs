using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class horrormove : MonoBehaviour
{
    //mouse move
    public Transform playerBody;
    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");    
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);       
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

