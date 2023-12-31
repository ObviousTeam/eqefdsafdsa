using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Unity.VisualScripting;

public class Photontovisualscripting : MonoBehaviourPunCallbacks
{
    public override void OnConnectedToMaster()
    {
        CustomEvent.Trigger(gameObject, "OnConnected ToMaster");
    }

    public override void OnJoinedRoom()
    {
        CustomEvent.Trigger(gameObject, "OnJoinedRoom");
    }
}