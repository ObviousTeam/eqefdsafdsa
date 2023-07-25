using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class leaveserverbutton : MonoBehaviour
{
    public void OnButtonClick()
    {
        Photon.Pun.PhotonNetwork.Disconnect();
        Photon.Pun.PhotonNetwork.LoadLevel("Lobby");

    }
}

