using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NetworkCubeMove : NetworkBehaviour
{
    public float speed = 3.0F;
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
        moveDirection=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        moveDirection =  Camera.main.transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        moveDirection.y = 0.0f;
        GetComponent<CharacterController>().Move(moveDirection * Time.deltaTime);
    }
}
