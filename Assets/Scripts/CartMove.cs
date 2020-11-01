using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMove : MonoBehaviour
{
    private Rigidbody rb;
    private float rotateSpeed = 120.0f;
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate around y - axis
        Quaternion rotationDelta = Quaternion.Euler(new Vector3(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0));
        rb.MoveRotation(rb.rotation * rotationDelta);

        // Move forward / backward
        Vector3 forward;
        rb.position += speed * Input.GetAxis("Vertical") * Time.deltaTime * -transform.forward;
    }
}
