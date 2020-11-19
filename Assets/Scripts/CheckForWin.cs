using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CheckForWin : MonoBehaviourPunCallbacks
{
    bool gameWon = false;
    AudioSource gameWinSFX;

    UI ui;
    ObjectsInCarts objectsInCarts;

    // Start is called before the first frame update
    void Start()
    {
        gameWinSFX = GetComponent<AudioSource>();
        ui = FindObjectOfType<UI>();
        objectsInCarts = FindObjectOfType<ObjectsInCarts>();
    }

    // Update is called once per frame
    void Update()
    {
       if (!gameWon)
		{
            CheckForItemsInCarts();
		}
    }

    void CheckForItemsInCarts()
	{
        List<string> itemsToWin = ui.GetIngredientNames();
        List<string> objectsInAllCarts = objectsInCarts.objectsInAllCarts;

        foreach (string item in itemsToWin)
        {
            bool foundThisItem = false;
            foreach (string cartItem in objectsInAllCarts)
            {
                if (item.Equals(cartItem))
				{
                    foundThisItem = true;
                    break;
				}
            }
            if (!foundThisItem)
			{
                return;
			}
        }

        gameWon = true;
        AudioSource music = GameObject.Find("Music").GetComponent<AudioSource>();
        music.Stop();
        gameWinSFX.Play();

        StartCoroutine(WaitTenSec());
    }

    IEnumerator WaitTenSec() {
        yield return new WaitForSeconds(10f);
        Destroy(RoomManager.Instance);
        PhotonNetwork.LeaveRoom();
        //PhotonNetwork.Disconnect();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public override void OnLeftRoom()
    {
        PhotonNetwork.Disconnect();
        //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
