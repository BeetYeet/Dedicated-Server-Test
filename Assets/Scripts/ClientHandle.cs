﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientHandle : MonoBehaviour
{
    public static void Welcome(Packet packet)
    {
        string msg = packet.ReadString();
        int myId = packet.ReadInt();

        Debug.Log($"Messsage from server: {msg}");
        Client.instance.myId = myId;
        ClientSend.WelcomeReceived();
    }
}
