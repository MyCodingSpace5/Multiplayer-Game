using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiona : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
    	if(collision.gameObject.tag == "Enemy")
    	{
    	    Destroy(gameObject);
    	}
    }
}
