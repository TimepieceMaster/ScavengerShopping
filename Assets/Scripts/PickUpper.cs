using Gvr.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;

public class PickUpper : MonoBehaviour
{
    public Transform viewingPosition;
    public Transform holdingPosition;
    public float holdingDistance = 0f;
    private Rigidbody heldObject;
    private GameObject currentPickupabbleLookingAt;
    private int onlyPickUppableObjectsMask = 1 << 8;
    private KeyCode pickUpButtonController = KeyCode.Joystick1Button0;
    private KeyCode pickUpButtonKeyboard = KeyCode.E;
    private KeyCode moveBackwardButtonController = KeyCode.Joystick1Button1;
    private KeyCode moveForwardButtonController = KeyCode.Joystick1Button9;
    private KeyCode rotateObjectController = KeyCode.Joystick1Button3;
    private float pickUpDistance = 5.0f;
    private float pickUpSpeed = 15.0f;
    private float rotateObjectSpeed = 120.0f;
    private float moveForwardBackwardSpeed = 1.0f;
    private float maxMoveForwardBackwardDistance = 1.5f;
    private Color objectHighlightColor = Color.red;

    void AttemptPickup()
	{
        RaycastHit raycastHit;
        Physics.Raycast(viewingPosition.position, viewingPosition.forward, out raycastHit, pickUpDistance, onlyPickUppableObjectsMask);
        if (raycastHit.rigidbody != null)
		{
            heldObject = raycastHit.rigidbody;
            heldObject.freezeRotation = true;

            // make sure we unhighlight the object
            if (currentPickupabbleLookingAt != null)
			{
                Material previousObjectMaterial = currentPickupabbleLookingAt.GetComponent<Renderer>().material;
                previousObjectMaterial.color = Color.white;
            }
        }
	}

    void HoldObject()
	{
        heldObject.velocity = pickUpSpeed * (holdingPosition.position - heldObject.position);
        if(Input.GetKey(moveBackwardButtonController))
		{
            if (holdingDistance < maxMoveForwardBackwardDistance)
			{
                float holdingDistanceDelta = moveForwardBackwardSpeed * Time.deltaTime;
                holdingDistance += holdingDistanceDelta;
                holdingPosition.position += holdingDistanceDelta * (holdingPosition.position - viewingPosition.position).normalized;
            }
		}
        if (Input.GetKey(moveForwardButtonController))
        {
            if (holdingDistance > -maxMoveForwardBackwardDistance)
            {
                float holdingDistanceDelta = -moveForwardBackwardSpeed * Time.deltaTime;
                holdingDistance += holdingDistanceDelta;
                holdingPosition.position += holdingDistanceDelta * (holdingPosition.position - viewingPosition.position).normalized;
            }
        }
        if (Input.GetKey(rotateObjectController))
		{
            heldObject.freezeRotation = false;
            Quaternion rotationDelta = Quaternion.Euler(new Vector3(0, rotateObjectSpeed * Time.deltaTime, 0));
            heldObject.MoveRotation(heldObject.rotation * rotationDelta);
            heldObject.freezeRotation = true;
		}
    }

    void DropObject()
	{
        heldObject.freezeRotation = false;
        heldObject = null;
        holdingPosition.position -= holdingDistance * (holdingPosition.position - viewingPosition.position).normalized;
        holdingDistance = 0;
	}

    void LookForPickuppableObjects()
	{
        RaycastHit raycastHit;
        GameObject pickuppableObject;
        Physics.Raycast(viewingPosition.position, viewingPosition.forward, out raycastHit, pickUpDistance, onlyPickUppableObjectsMask);
        
        // we're looking at a pickuppable object
        if (raycastHit.rigidbody != null)
        {
            // we weren't previously looking at something
            if (currentPickupabbleLookingAt == null)
			{
                // set object color to highlight color
                pickuppableObject = raycastHit.transform.gameObject;
                Material objectMaterial = pickuppableObject.GetComponent<Renderer>().material;
                objectMaterial.color = objectHighlightColor;
                currentPickupabbleLookingAt = pickuppableObject;
            }
            // we're looking at something new
            else if (currentPickupabbleLookingAt != raycastHit.transform.gameObject)
			{
                // set new object color to highlight color
                pickuppableObject = raycastHit.transform.gameObject;
                Material objectMaterial = pickuppableObject.GetComponent<Renderer>().material;
                objectMaterial.color = objectHighlightColor;

                // unhighlight object previously looking at
                Material previousObjectMaterial = currentPickupabbleLookingAt.GetComponent<Renderer>().material;
                previousObjectMaterial.color = Color.white;

                // make new object currently looked at object
                currentPickupabbleLookingAt = pickuppableObject;
            }
        }
        // no longer looking at a pickuppable object
        else
		{
            // unhighlight whatever we were previously looking at (if anything)
            if (currentPickupabbleLookingAt != null)
			{
                Material previousObjectMaterial = currentPickupabbleLookingAt.GetComponent<Renderer>().material;
                previousObjectMaterial.color = Color.white;
                currentPickupabbleLookingAt = null;
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        // holding an object
        if (heldObject != null)
		{
            HoldObject();
        }
        // check to see if looking at object that could be held
        else
        {
            LookForPickuppableObjects();
        }
        // trying to hold an object
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
