using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PickUppable : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject pickedUpBy;

    private bool isPickedUp = false;

    public void TogglePickUp(GameObject pickUpper)
	{
        if (!isPickedUp)
		{
            GetPickedUp(pickUpper);
		}
		else
		{
            GetDropped(pickUpper);
		}
	}

    private void GetPickedUp(GameObject pickUpper)
	{
        pickedUpBy = pickUpper;
        transform.position = pickedUpBy.transform.position;
        transform.parent = pickedUpBy.transform;
        
        rb.useGravity = false;
        rb.freezeRotation = true;
        isPickedUp = true;
    }

    public void GetDropped(GameObject pickUpper)
	{
        if (isPickedUp)
		{
            pickedUpBy = null;
            transform.parent = null;
            rb.useGravity = true;
            rb.freezeRotation = false;
            isPickedUp = false;
        }
	}

    private void Start()
	{
        rb = this.GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
        if (isPickedUp)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
