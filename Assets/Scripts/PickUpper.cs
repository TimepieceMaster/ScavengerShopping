using Gvr.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using UnityEngine;
using Photon.Pun;

public class PickUpper : MonoBehaviour
{
    public Transform viewingPosition;
    public Transform holdingPosition;
    public float holdingDistance = 0f;
    private Rigidbody heldObject;
    private UnityEngine.Collider heldObjectCollider;
    private GameObject currentPickupabbleLookingAt;
    private int onlyPickUppableObjectsMask = 1 << 8;
    private KeyCode pickUpButtonController = KeyCode.JoystickButton3; //KeyCode.JoystickButton0; 
    private KeyCode pickUpButtonKeyboard = KeyCode.E;
    private KeyCode moveBackwardButtonKeyboard = KeyCode.R;
    private KeyCode moveForwardButtonKeyboard = KeyCode.F;
    private KeyCode rotateObjectKeyboard = KeyCode.Q;
    private KeyCode moveBackwardButtonController = KeyCode.JoystickButton1; //KeyCode.JoystickButton1; 
    private KeyCode moveForwardButtonController = KeyCode.JoystickButton10; //KeyCode.JoystickButton7;
    private KeyCode rotateObjectController =  KeyCode.JoystickButton8; //KeyCode.JoystickButton2;
    private bool pickUpKeyPressed = false;
    private float pickUpDistance = 2.5f;
    private float pickUpSpeed = 30.0f;
    private float rotateObjectSpeed = 120.0f;
    private float moveForwardBackwardSpeed = 1.0f;
    private float maxMoveForwardBackwardDistance = 1.5f;
    private Color objectHighlightColor = Color.red;
    PhotonView PV;

    void AttemptPickup()
	{
        RaycastHit raycastHit;
        Physics.Raycast(viewingPosition.position, viewingPosition.forward, out raycastHit, pickUpDistance, onlyPickUppableObjectsMask);
        if (raycastHit.rigidbody != null)
		{
            heldObject = raycastHit.rigidbody;
            heldObject.freezeRotation = true;

            // disable its collider
            heldObjectCollider = raycastHit.collider;
            heldObjectCollider.enabled = false;

            // make sure we unhighlight the object
            if (currentPickupabbleLookingAt != null)
			{
                SetColorPickuppable(currentPickupabbleLookingAt, Color.white);
                currentPickupabbleLookingAt = null;
            }
        }
	}

    void HoldObject()
	{
        heldObject.velocity = pickUpSpeed * (holdingPosition.position - heldObject.position).normalized * Time.deltaTime;

        if(Input.GetKey(moveBackwardButtonController) || Input.GetKey(moveBackwardButtonKeyboard))
		{
            if (holdingDistance < maxMoveForwardBackwardDistance)
			{
                float holdingDistanceDelta = moveForwardBackwardSpeed * Time.deltaTime;
                holdingDistance += holdingDistanceDelta;
                holdingPosition.position += holdingDistanceDelta * (holdingPosition.position - viewingPosition.position).normalized;
            }
		}
        if (Input.GetKey(moveForwardButtonController) || Input.GetKey(moveForwardButtonKeyboard))
        {
            if (holdingDistance > -maxMoveForwardBackwardDistance)
            {
                float holdingDistanceDelta = -moveForwardBackwardSpeed * Time.deltaTime;
                holdingDistance += holdingDistanceDelta;
                holdingPosition.position += holdingDistanceDelta * (holdingPosition.position - viewingPosition.position).normalized;
            }
        }
        if (Input.GetKey(rotateObjectController) || Input.GetKey(rotateObjectKeyboard))
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

        heldObjectCollider.enabled = true;

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
                SetColorPickuppable(pickuppableObject, objectHighlightColor);

                currentPickupabbleLookingAt = pickuppableObject;
            }
            // we're looking at something new
            else if (currentPickupabbleLookingAt != raycastHit.transform.gameObject)
			{
                // set new object color to highlight color
                pickuppableObject = raycastHit.transform.gameObject;
                SetColorPickuppable(pickuppableObject, objectHighlightColor);

                // unhighlight object previously looking at
                SetColorPickuppable(currentPickupabbleLookingAt, Color.white);

                // make new object currently looked at object
                currentPickupabbleLookingAt = pickuppableObject;
            }

            if (currentPickupabbleLookingAt.GetComponent<PhotonView>() != null) {
                currentPickupabbleLookingAt.GetComponent<PhotonView>().RequestOwnership();
            }
        }
        // no longer looking at a pickuppable object
        else
		{
            // unhighlight whatever we were previously looking at (if anything)
            if (currentPickupabbleLookingAt != null)
			{
                SetColorPickuppable(currentPickupabbleLookingAt, Color.white);
                currentPickupabbleLookingAt = null;
			}
		}
    }

    void SetColorPickuppable(GameObject pickuppable, Color c)
	{
        Material[] objectMaterials = pickuppable.GetComponent<Renderer>().materials;
        foreach (Material m in objectMaterials)
		{
            m.color = c;
		}
	}

    void Awake()
	{
		PV = GetComponent<PhotonView>();
	}

	private void Update()
	{
        pickUpKeyPressed = false;
		if (Input.GetKeyDown(pickUpButtonController) || Input.GetKeyDown(pickUpButtonKeyboard))
		{
            pickUpKeyPressed = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate()
    {
        if(!PV.IsMine) {
			return;
        }
        // holding an object
        if (heldObject != null)
		{
            HoldObject();
        }
        else
		{
            LookForPickuppableObjects();
        }
        // trying to hold an object
        if (pickUpKeyPressed)
		{
            pickUpKeyPressed = false;
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
