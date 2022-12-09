using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    float speed = 6.0f;
    public float jumpSpeed = 1f;
    public float gravity = 5.0f;
    public GameObject playermodel;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 LookatDirection = Vector3.zero;
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
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //Jumping
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
