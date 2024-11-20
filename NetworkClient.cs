using UnityEngine;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine.UI;
public class ClientNetworkManager : MonoBehaviour
{
    public GameObject uiLandscape;
    public GameObject entityLandscape;
    public InputField addressField;
    public InputField portField;
    private NetworkManager networkManager;
    private UnityTransport transport;
    public string ipAddress;
    public ushort port;
    void Start()
    {
        networkManager = GetComponent<NetworkManager>();
        transport = GetComponent<UnityTransport>();
        uiLandscape.SetActive(true);
    }
    public void StartClient()
    {
    	ipAddress = addressField.text;
    	port = (ushort)int.Parse(portField.text);
    	transport.ConnectionData.Address = ipAddress; 
        transport.ConnectionData.Port = port; 
    	networkManager.StartClient();
    	uiLandscape.SetActive(false);
    }
    void Update()
    {
    	transport.ConnectionData.Address = ipAddress; 
        transport.ConnectionData.Port = port; 
    }
}

