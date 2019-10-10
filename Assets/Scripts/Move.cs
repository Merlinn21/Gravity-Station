using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;
    public float topSpeed = 100f;
    private Rigidbody rb;
    private Vector2 movement;
    private Rotate rotation;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rotation = gameObject.GetComponent<Rotate>();
    }

    private void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        moveChar(movement);
        if (rb.velocity.magnitude > topSpeed)
            rb.velocity = rb.velocity.normalized * topSpeed;
    }

    void moveChar(Vector2 direction)
    {
        if(!rotation.rotateUp)
            rb.AddRelativeForce(direction * speed);
        else if(rotation.rotateUp)
            rb.AddRelativeForce(-direction * speed);
    }

    
    
}
