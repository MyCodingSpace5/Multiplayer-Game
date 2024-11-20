using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
public class AutoInitScene : NetworkBehaviour
{
    void Start()
    {
        return;
    }
    public override void OnNetworkSpawn()
    {
    	if(IsClient || !NetworkManager.Singleton.IsClient)
    	{
    	    NetworkManager.Singleton.SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);	
    	}
    	NetworkManager.Singleton.SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
