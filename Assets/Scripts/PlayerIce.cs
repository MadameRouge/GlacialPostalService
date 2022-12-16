using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIce : MonoBehaviour
{
    //References to other thingsd
    public Transform PlayerObject;
    private Rigidbody rb;
    private PlayerMovement pm;

    //Sliding
    public float maxSlideSpeed;
    public float slideForce;
    private float slideTimer;

    public float slideYScale;
    private float startYScale;

    //Input
    private float horizontalInput;
    private float verticalInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();

        startYScale = PlayerObject.localScale.y;
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void Sliding()
    {
        PlayerObject.localScale = new Vector3(PlayerObject.localScale.x, slideYScale, PlayerObject.localScale.z);
        rb.AddForce(Vector3.down * 5f, ForceMode.Impulse);

        slideTimer = maxSlideSpeed;

        slideTimer -= Time.deltaTime;
    }
}
