using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]

public class NewPlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    float speed = 6.0f;
    public float jumpSpeed = 10f;
    public float gravity = 5.0f;
    public GameObject playermodel;
    public GameObject hitTarget;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 LookatDirection = Vector3.zero;

    private int CheckLayers;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Player Movement
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, rb.velocity.y, speed);
        }
        //Player Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        //CheckLayers is checking for Layer 15 (Water) and then inverting it so that the raycast looks for everything except layer 15.
        //If it detects Layer 15, the player cannot jump.
        CheckLayers = 1 << 15;
        CheckLayers = ~CheckLayers;
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 1f, CheckLayers))
        {
                rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
    }
    //Player movement on different surfaces
    private void OnCollisionEnter(Collision collision)
    {
        //Ice
        if (collision.gameObject.layer == 13)
        {
            speed = 5.0f;
            rb.drag = 0.5f;
            Debug.Log("Ice Detected");
        }
        //Snow
        else if (collision.gameObject.layer == 14)
        {
            speed = 5.0f;
            rb.drag = 1.0f;
            Debug.Log("Snow Detected");
        }
        //Grass
        else if (collision.gameObject.layer == 16)
        {
            speed = 5.0f;
            rb.drag = 0.25f;
            Debug.Log("Grass Detected");
        }
    }
}
