using UnityEngine;
using Unity.Netcode;

    public class WorldSpawner : NetworkBehaviour
{
    public GameObject[] worldPrefabs; // Array of world element prefabs

    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            SpawnWorldElements();
        }
    }

    private void SpawnWorldElements()
    {
        foreach (GameObject prefab in worldPrefabs)
        {
            GameObject worldElement = Instantiate(prefab);
            if(worldElement.GetComponent<NetworkObject>() != null)
            {
            	worldElement.GetComponent<NetworkObject>().Spawn();
            }
            else
            {
            	worldElement.AddComponent<NetworkObject>();
            	worldElement.AddComponent<PlayerTransform>();
            	worldElement.GetComponent<NetworkObject>().Spawn();
            }
        }
    }
}

