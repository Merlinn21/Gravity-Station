using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject HideObj;
    private Renderer mat;
    public Material greenButton;
    private GameObject destroyGate;
    private bool open = false;

    private void Start()
    {
        mat = gameObject.GetComponent<Renderer>();  
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obj" && open == false)
        {
            mat.material = greenButton;
            HideObj.GetComponentInChildren<Animator>().Play("GateOpen");
            Destroy(collision.gameObject);
            Invoke("StopAnimGate", 2);
            open = true;
        }
    }

    private void StopAnimGate()
    {
        HideObj.GetComponentInChildren<Animator>().speed = 0;
    }
}
