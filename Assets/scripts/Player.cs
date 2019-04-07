using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Player : MonoBehaviour

{
	//Источник звуков
	sfx AudioSource;
	
	//private float Speed;
	
	//public int acceleration;
    //public float force = 10.0f;

    void Start()
    {
		
	/* AudioSource = Global.sfx.GetComponent<sfx>();
AudioSource.bump.Play();
Debug.Log ( "Play" );	 */
	//rb = GetComponent<Rigidbody>();
	//Global.sfx.GetComponent<Sfx>().enabled = false;
	  
    }
	

    
     void Update()
    {
		//Global.sfx.SetActive(false);
		//Vector3 v3Velocity = rb.velocity;
		//Speed = rb.velocity.magnitude;
		//Debug.Log ( "my: " + Speed );
        
    }
	
	
	//Звук при сталкновении
	private void OnCollisionEnter(Collision collname)
	{
		AudioSource = Global.sfx.GetComponent<sfx>();
		
		//Звук клонирования
		if( collname.gameObject.name == "vrag2" ) {
		AudioSource.bump.Play();
		}
		
		//Звук удара о мяч
		if( collname.gameObject.name == "vrag2" || collname.gameObject.name == "vrag2(Clone)"  ) {
		AudioSource.bump2.Play();
		}
		
		//Звук удара о пол
		if( collname.gameObject.name == "floor100" ) {
		AudioSource.bumpAll.Play();
		}
		
	}
	
	/* void OnCollisionStay()
         {
			 //for ( int i=0; i<5; i++ )
             //rb.AddForce(Vector3.up * jumpForce);
         } */
	
	
}
