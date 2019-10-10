using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravityForce;
    private Rigidbody rigidBody;
    private bool reverseGravity = false;
    private bool test = false;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && reverseGravity == false)
        {
            GravityReverse();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && reverseGravity == true)
        {
            ResetGravity();
        }
        
        if (test)
            rigidBody.AddForce(new Vector3(0, gravityForce));
        else if (!test)
            rigidBody.AddForce(new Vector3(0, 0));
    }
    
    void GravityReverse()
    {
        rigidBody.useGravity = false;
        reverseGravity = true;
        test = true;
    }

    void ResetGravity()
    {
        rigidBody.useGravity = true;
        reverseGravity = false;
        test = false;
    }
}
