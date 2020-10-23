using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkCubeMove : NetworkBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 1.0F;
    private Vector3 moveDirection = Vector3.zero;

    public override void OnStartAuthority()
    {
        enabled = true;

    }

    [Client]
    private void Update()
    {
        if (!hasAuthority) { return; }

        CmdMove();
    }

    [Command]
    private void CmdMove()
    {
        // Validate logic here

        RpcMove();
    }

    [ClientRpc]
    private void RpcMove() {
        //transform.Translate(movement);
        moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
        moveDirection =  GetComponentInChildren<Camera>().transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        moveDirection.y = 0.0f;
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);
    }
}
