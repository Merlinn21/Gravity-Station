using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;
    public bool rotateUp = false;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() { 
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!rotateUp)
                rotateUp = true;
            else if (rotateUp)
                rotateUp = false;
        }
        
        if (rotateUp)
        {
            Vector3 to = new Vector3(0, 0, 180f);
            if (Vector3.Distance(transform.eulerAngles, to) > 0.01f)
            {
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * rotateSpeed);
            }
            else
            {
                transform.eulerAngles = to;
            }
        }
        else if (!rotateUp)
        {
            Vector3 minTo = new Vector3(0, 0, 0);
            if (Vector3.Distance(transform.eulerAngles, minTo) > 0.01f)
            {
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, minTo, Time.deltaTime * rotateSpeed);
            }
            else
            {
                transform.eulerAngles = minTo;
            }
        }
    }
}
