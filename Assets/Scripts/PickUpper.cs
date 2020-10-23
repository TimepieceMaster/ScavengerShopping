using Gvr.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpper : MonoBehaviour
{
    public Transform viewingPosition;
    public Transform holdingPosition;
    private Rigidbody heldObject;
    private int onlyPickUppableObjectsMask = 1 << 8;
    public KeyCode pickUpButtonController = KeyCode.Joystick1Button0;
    public KeyCode pickUpButtonKeyboard = KeyCode.E;
    public float pickUpDistance = 5.0f;
    public float pickUpSpeed = 15.0f;

    void AttemptPickup()
	{
        RaycastHit raycastHit;
        Physics.Raycast(viewingPosition.position, viewingPosition.forward, out raycastHit, pickUpDistance, onlyPickUppableObjectsMask);
        if (raycastHit.rigidbody != null)
		{
            heldObject = raycastHit.rigidbody;
            heldObject.freezeRotation = true;
        }
	}

    void HoldObject()
	{
        heldObject.velocity = pickUpSpeed * (holdingPosition.position - heldObject.position);
    }

    void DropObject()
	{
        heldObject.freezeRotation = false;
        heldObject = null;
	}

    // Update is called once per frame
    void Update()
    {
        if (heldObject != null)
		{
            HoldObject();
        }
        if (Input.GetKeyDown(pickUpButtonController) || Input.GetKeyDown(pickUpButtonKeyboard))
		{
            if (heldObject == null)
			{
                AttemptPickup();
            }
            else
			{
                DropObject();
			}
		}
    }
}
