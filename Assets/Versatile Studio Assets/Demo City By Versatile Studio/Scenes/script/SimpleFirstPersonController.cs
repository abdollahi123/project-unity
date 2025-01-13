using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFirstPersonController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private float verticalRotation = 0;



    public GameObject player;




    void Update()
    {

       
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, mouseX, 0);

   
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -60, 60);
       

    
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 movement = new Vector3(moveRight, 0, moveForward);
        transform.Translate(movement, Space.World);
    }
}