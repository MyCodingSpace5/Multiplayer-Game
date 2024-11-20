using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
public class SecondPlayerMovement : NetworkBehaviour
{
    public Rigidbody2D rb;
    public Vector3 snapshot1;
    public Vector3 snapshot2;
    public float moveHorizontal;
    public float moveVertical;
    public float facingDirection;
    public Vector2 movement;
    public Transform parenta;
    public GameObject objecta;
    // Start is called before the first frame update
    void Start()
    {
        parenta = GetComponent<Transform>();
       	rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsOwner){
            return;
        }
        if(transform.position.y < 10){
           if(transform.position.x < 10)
           {
              MoveHandler();	
           }	
        }
    }
    void MoveHandler()
    {
    	moveHorizontal = Input.GetAxisRaw("Horizontal");
    	moveVertical = Input.GetAxisRaw("Vertical");
    	movement = new Vector2(moveHorizontal, moveVertical).normalized;
    	rb.velocity = (movement * 4);
  	facingDirection = moveHorizontal;
  	parenta.localScale = new Vector2(facingDirection, 1);
  	if(movement != new Vector2(0, 0))
  	{
  	   Instantiate(objecta, transform.position, transform.rotation);
  	}
    }
    
}
