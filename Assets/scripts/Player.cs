using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour

{
	
	//private GameObject Player;
	private Rigidbody rb;
	public int jumpForce = 100;
	
	//public int acceleration;
    //public float force = 10.0f;

    void Start()
    {
		
	rb = GetComponent<Rigidbody>();
	
	
	  
    }
	

    
    /* void Update()
    {
		
		//Позиция тачпада
		//Touch touch = Input.GetTouch(0);
		//Debug.Log ( touch.position );
		
		//Позиция игрока
		//Debug.Log ( transform.position );
        
    } */
	
	/* void OnCollisionStay()
         {
			 //for ( int i=0; i<5; i++ )
             //rb.AddForce(Vector3.up * jumpForce);
         } */
	
	
}
