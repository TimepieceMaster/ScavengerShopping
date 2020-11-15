using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class Timer : MonoBehaviour
{

    bool startTimer = false;
    double timerIncrementValue;
    double startTime;
    ExitGames.Client.Photon.Hashtable CustomeValue;
    public Text T;
    public float seconds, minutes;

    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<Text>() as Text;

        if (PhotonNetwork.LocalPlayer.IsMasterClient)
         {
             CustomeValue = new ExitGames.Client.Photon.Hashtable();
             startTime = PhotonNetwork.Time;
             startTimer = true;
             CustomeValue.Add("StartTime", startTime);
             PhotonNetwork.CurrentRoom.SetCustomProperties(CustomeValue);
         }
         else
         {
             startTime = double.Parse(PhotonNetwork.CurrentRoom.CustomProperties["StartTime"].ToString());
             startTimer = true;
         }
    }

    // Update is called once per frame
    void Update()
    {
        if (!startTimer) return;

        timerIncrementValue = PhotonNetwork.Time - startTime;

        T.text = timerIncrementValue.ToString("00");
        /*

        minutes = (int)(Time.time / 60f);
        seconds = (int)(Time.time % 60f);
        T.text = minutes.ToString("00") + ":" + seconds.ToString("00");*/
    }
}
