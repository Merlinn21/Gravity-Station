using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
