using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float defaultSpeed = 12f;
    public float sprintSpeed = 20f;
    private Vector3 velocity;
    public float gravity = -9.81f;
    public LayerMask groundMask;
    private float speed;

    void Start()
    {
        
    }

    void Update()
    {
        // TODO: Might be able to remove no grounding needed if no jumping
        // Grounded check, resets velocity in y direction to small amount
        // if(isGrounded && velocity.y < 0){
        //     controller.slopeLimit = 45.0f; // fix this
        //     velocity.y = -2f;
        // }

        // look around
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // handle sprinting
        if(Input.GetKey("left shift")){
            speed = sprintSpeed;
        } else{
            speed = defaultSpeed;
        }

        // movement
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // jumping
        // if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
        //     controller.slopeLimit = 100.0f; // fix this
        //     velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        // }

        // gravity setup
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
