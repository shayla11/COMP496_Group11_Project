using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Shayla Sexton

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f; //Increase Speed for bigger env.
    public bool canMoveWASD = true;

    void Update()
    {
        if (canMoveWASD){
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime) ;
        }
    }
}
