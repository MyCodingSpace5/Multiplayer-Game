using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartClient()
    {
    	NetworkManager.Singleton.StartHost();
    }
}
