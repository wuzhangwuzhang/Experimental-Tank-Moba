﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Photon.MonoBehaviour {

    public GameObject[] redSpawn;
    public GameObject[] blueSpawn;
    public GameObject target;
    public int state = 0;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target"); 
    }

    void Connect()
    {
        PhotonNetwork.ConnectToBestCloudServer("V-A1");
        state = 1;
        
    }

    void Update()
    {
        
    }


    private void OnGUI()
    {
        switch (state)
        {
            case 0:
                if (GUI.Button(new Rect(10, 10, 100, 30), "Connect"))
                    Connect();
                break;
            case 1:
                GUI.Label(new Rect(10, 10, 100, 30), "Connected");
                break;
        }
    }
}
