using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    public float runSpeed = 16f;
    public float jogSpeed = 6f;
    float speed = 6.0f;
    public float jumpSpeed = 5f;
    public float gravity = 10.0f;

private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Locomotion();
    }

    void Locomotion()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = jogSpeed;
        }

        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //Jumping/Crouching
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                characterController.height = 0.5f;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
