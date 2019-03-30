using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour

{
	
	//private GameObject Player;
	private Rigidbody rb;
	public int jumpForce = 100;
	
	private float Speed;
	
	//public int acceleration;
    //public float force = 10.0f;

    void Start()
    {
		
	rb = GetComponent<Rigidbody>();
	
	  
    }
	

    
     void Update()
    {
		
		//Vector3 v3Velocity = rb.velocity;
		Speed = rb.velocity.magnitude;
		Debug.Log ( "my: " + Speed );
        
    } 
	
	/* void OnCollisionStay()
         {
			 //for ( int i=0; i<5; i++ )
             //rb.AddForce(Vector3.up * jumpForce);
         } */
	
	
}
