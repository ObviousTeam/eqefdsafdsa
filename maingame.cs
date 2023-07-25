using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

// This File Goes in and empty object in unity

public class maingame : MonoBehaviour
{
    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector3 point1 = new Vector3(0.0f, 1.0f, 0.0f);
        Quaternion rotation1 = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
        GameObject playermodel = Photon.Pun.PhotonNetwork.Instantiate("player", point1, rotation1, 0, null);
        Transform vectorofplayermodel = playermodel.transform.GetChild(1);
        vectorofplayermodel.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
