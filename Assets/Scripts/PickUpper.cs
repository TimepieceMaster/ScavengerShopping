﻿using Gvr.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpper : MonoBehaviour
{
    public Transform viewingPosition;
    public Transform holdingPosition;
    public float holdingDistance = 0f;
    private Rigidbody heldObject;
    private int onlyPickUppableObjectsMask = 1 << 8;
    private KeyCode pickUpButtonController = KeyCode.Joystick1Button0;
    private KeyCode pickUpButtonKeyboard = KeyCode.E;
    private KeyCode moveBackwardButtonController = KeyCode.Joystick1Button1;
    private KeyCode moveForwardButtonController = KeyCode.Joystick1Button9;
    private float pickUpDistance = 5.0f;
    private float pickUpSpeed = 15.0f;
    private float moveForwardBackwardSpeed = 1.0f;
    private float maxMoveForwardBackwardDistance = 1.5f;

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
    }

    void DropObject()
	{
        heldObject.freezeRotation = false;
        heldObject = null;
        holdingPosition.position -= holdingDistance * (holdingPosition.position - viewingPosition.position).normalized;
        holdingDistance = 0;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
		{
            Debug.Log("Button 1");
		}
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Debug.Log("Button 2");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            Debug.Log("Button 3");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))
        {
            Debug.Log("Button 4");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            Debug.Log("Button 5");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button6))
        {
            Debug.Log("Button 6");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            Debug.Log("Button 7");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button8))
        {
            Debug.Log("Button 8");
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            Debug.Log("Button 9");
        }
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
