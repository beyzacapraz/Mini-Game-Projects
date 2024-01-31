using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Player_movement : MonoBehaviour
{
    CharacterController characterController;
    Vector3 move_direction;
    [SerializeField] float speed;
    [SerializeField] float gravity;
    [SerializeField] float jump_force;
    [SerializeField] float vertical_speed;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        move_direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        move_direction = transform.TransformDirection(move_direction);
        float currentSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= 2; // Increase speed when left shift is held down
        }

        move_direction *= currentSpeed * Time.deltaTime;
        //ApplyGravity();
        characterController.Move(move_direction);
        // Ensure y-axis position remains at 10
        Vector3 currentPosition = transform.position;
        currentPosition.y = 10f;
        transform.position = currentPosition;


    }
    /*void ApplyGravity()
    {
        vertical_speed -= gravity * Time.deltaTime;
        Jump();
        move_direction.y = vertical_speed * Time.deltaTime;
    }
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && characterController.isGrounded)
        {
            vertical_speed = jump_force;
        }
    }*/
}
