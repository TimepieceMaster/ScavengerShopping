using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PickUppable : MonoBehaviour
{
    private Rigidbody rb;
    private Transform heldPosition;

    private bool isPickedUp = false;

    public void TogglePickUp(Transform hp)
	{
        if (!isPickedUp)
		{
            GetPickedUp(hp);
		}
		else
		{
            GetDropped();
		}
	}

    private void GetPickedUp(Transform hp)
	{
        heldPosition = hp;
        rb.freezeRotation = true;
        isPickedUp = true;
    }

    public void GetDropped()
	{
        if (isPickedUp)
		{
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
            rb.velocity = 15 * (heldPosition.position - transform.position);
        }
    }
}
