using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;
public class ButtonManagement : MonoBehaviour
{
    public GameObject Hud;
    public GameObject hud2;
    public GameObject hud3;
    public NetworkManager manager;
    // Start is called before the first frame update
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        return;
    }
    public void createANewScene()
    {
    	Destroy(manager);
 	SceneManager.LoadScene(1);   	
    }
    public void joinAServer()
    {
    	hud2.SetActive(false);
	Hud.SetActive(true);
    }
    public void selectYourRole()
    {
    	hud2.SetActive(false);
    	hud3.SetActive(true);
    }
    public void goBack()
    {
    	hud3.SetActive(false);
    	hud2.SetActive(true);
    }
    public void back()
    {
    	hud2.SetActive(true);
    	Hud.SetActive(false);
    }
}
