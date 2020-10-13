using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 1.0F;
    private CharacterController controller;
    private Camera cam;

	void Start()
	{
        controller = GetComponent<CharacterController>();
        cam = GetComponentInChildren<Camera>();
    }

	void Update()
    {
        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = cam.transform.TransformDirection(Vector3.forward);
        forward.y = 0;
        forward.Normalize();
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
        //source:https://docs.unity3d.com/ScriptReference/CharacterController.SimpleMove.html
    }
}