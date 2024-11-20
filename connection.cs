using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class connection : MonoBehaviour
{
    private NetworkManager ntManager;
    // Start is called before the first frame update
    void Start()
    {
    	ntManager = GetComponent<NetworkManager>();
        ntManager.OnClientConnectedCallback += clientConnected;
        ntManager.StartServer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void clientConnected(ulong clientId)
    {
    	print("Client is connected" + clientId);
    }
}
