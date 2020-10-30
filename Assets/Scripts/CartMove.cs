using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CartMove : MonoBehaviour
{
    private Rigidbody rb;
    private float rotateSpeed = 120.0f;
    private float speed = 1.0f;
    private PhotonView PV;
    // Start is called before the first frame update
    void Awake()
	{
		PV = GetComponent<PhotonView>();
        rb = GetComponentInChildren<Rigidbody>();
	}

    void Start()
    {
        if(!PV.IsMine)
		{
			Destroy(GetComponentInChildren<Camera>().gameObject);
			Destroy(rb);
		}
        GetComponentInChildren<TextMesh>().text = PhotonNetwork.NickName;
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!PV.IsMine) {
			return;
        }
        // Rotate around y - axis
        Quaternion rotationDelta = Quaternion.Euler(new Vector3(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0));
        rb.MoveRotation(rb.rotation * rotationDelta);

        // Move forward / backward
        Vector3 forward;
        rb.position += speed * Input.GetAxis("Vertical") * Time.deltaTime * -transform.forward;
    }
}
