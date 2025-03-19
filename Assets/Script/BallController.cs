using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;
    public float jumpSpeed;
    float horizontalInput;
    float verticalInput;
    Rigidbody rb;
    bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        MoveBall();
        Jump(); 
    }

    void MoveBall()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(movement * ballSpeed);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0));
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

}
