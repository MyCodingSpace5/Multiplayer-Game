using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifecycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   	
    }
    void Awake()
    {
    	print("UwU");
    	StartCoroutine("Coroutine");
    }
    IEnumerator Coroutine()
    {
    	print("Coroutine is called");
    	yield return new WaitForSeconds(3);
    	Destroy(gameObject);
    }
}
