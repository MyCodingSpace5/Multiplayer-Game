using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class ObjectInitlization : MonoBehaviour
{
    public GameObject[] playerPrefabs; 
    public Vector3 spawnPosition; 
    private void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    }

    private void OnClientConnected(ulong clientId)
    {
        if (!NetworkManager.Singleton.IsServer) return;

        int prefabIndex = PlayerPrefs.GetInt("CharacterIndex", 0);

        if (prefabIndex < 0 || prefabIndex >= playerPrefabs.Length)
        {
            Debug.LogError("Invalid prefab index selected!");
            return;
        }

        GameObject selectedPrefab = playerPrefabs[prefabIndex];
        GameObject playerInstance = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);

        NetworkObject networkObject = playerInstance.GetComponent<NetworkObject>();
        networkObject.SpawnAsPlayerObject(clientId);
    }

    private void OnDestroy()
    {
        if (NetworkManager.Singleton != null)
        {
            NetworkManager.Singleton.OnClientConnectedCallback -= OnClientConnected;
        }
    }
}
