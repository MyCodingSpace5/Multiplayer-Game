using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnePreferences : MonoBehaviour
{
    public int preferences;
    private GameObject game;
    private InputField input;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("InputField (Legacy)");
        input = game.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeIndex()
    {
    	preferences = int.Parse(input.text);
    	PlayerPrefs.SetInt("CharacterIndex", preferences);
    	PlayerPrefs.Save();
    }
}
