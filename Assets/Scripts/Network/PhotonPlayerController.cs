using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PhotonPlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private PhotonView PV;
    private CharacterController controller;
    private Camera cam;
    private Vector3 moveAmount;
    private Vector3 smoothMoveVelocity;
    private float smoothTime = 0.15f;

    public float speed = 3.0F;
    public float rotateSpeed = 1.5F;

    void Awake()
	{
		//rb = GetComponent<Rigidbody>();
		PV = GetComponent<PhotonView>();
        controller = GetComponent<CharacterController>();
	}

    // Start is called before the first frame update
    void Start()
    {
        if(!PV.IsMine)
		{
			Destroy(GetComponentInChildren<Camera>().gameObject);
			Destroy(rb);
		}

        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PV.IsMine) {
			return;
        }
    }

    void FixedUpdate()
	{
		if(!PV.IsMine) {
			return;
        }
        Move();
		//rb.MovePosition(rb.position + transform.TransformDirection(moveAmount) * Time.fixedDeltaTime);
	}

    void Move()
	{
        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        /*
        Vector3 moveDir = new Vector3(0, 0, Input.GetAxisRaw("Vertical")).normalized;
        moveAmount = Vector3.SmoothDamp(moveAmount, moveDir * speed, ref smoothMoveVelocity, smoothTime);
        rb.MovePosition(rb.position + transform.TransformDirection(moveAmount) * Time.fixedDeltaTime);*/

        /*Vector3 targetVelocity = new Vector3(0, 0, Input.GetAxis("Vertical")).normalized;
        targetVelocity = transform.TransformDirection(targetVelocity)* Time.fixedDeltaTime * speed;
        Vector3 velocity = rb.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -10.0f, 10.0f);
        velocityChange.y = 0;
        velocityChange.x = 0;
        rb.AddForce(velocityChange, ForceMode.VelocityChange);*/

        Vector3 forward = cam.transform.TransformDirection(Vector3.forward);
        forward.y = 0;
        forward.Normalize();
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);

	}
}
