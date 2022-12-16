using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]

public class NewPlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    float speed = 6.0f;
    public float jumpSpeed = 1f;
    public float gravity = 5.0f;
    public GameObject playermodel;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 LookatDirection = Vector3.zero;

    void Start()
    {
        //Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //x, y, z
            rb.velocity = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //x, y, z
            rb.velocity = new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //x, y, z
            rb.velocity = new Vector3(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //x, y, z
            rb.velocity = new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //x, y, z
            rb.velocity = new Vector3(0, jumpSpeed, 0);
        }
    }
}
