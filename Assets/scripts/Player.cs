using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour

{
	
	//private GameObject Player;
	//private Rigidbody rb;
	
	//public float Speed = 20.0f;
	private GameObject canGameOver;
	private GameObject timer;
	//private GameObject test1;
	
	//public int acceleration;
    //public float force = 10.0f;
	
	private GameObject ToggelAkcel;

    void Start()
    {
		
	//rb = GetComponent<Rigidbody>();
	
	canGameOver = GameObject.Find("canGameOver");
	timer = GameObject.Find("timer");
	
	ToggelAkcel = GameObject.Find("ToggelAkcel");
	  
    }
	

    
    void Update()
    {
		
		//Позиция тачпада
		//Touch touch = Input.GetTouch(0);
		//Debug.Log ( touch.position );
		
		//Позиция игрока
		//Debug.Log ( transform.position );
		
		
		
		
		// Управление
		
		//Акселерометр
	
  /* Vector3 dir = Vector3.zero;
            dir.x = Input.acceleration.x;
            dir.z = Input.acceleration.y;
			//Debug.Log ( dir.z );

			//Корректировка чувствительности наклона по y
			if (dir.z > -0.57f ) { 
			dir.z = dir.z + 0.8f;
			}

			
            if (dir.sqrMagnitude > 1) dir.Normalize();
            dir *= Time.deltaTime;
			GetComponent<Rigidbody>().AddForce( (dir.x*force)*acceleration, 0, (dir.z * force) * acceleration, ForceMode.Force); */
			
			//Debug.Log ( dir.x );
	        
	

		// Джойстик (MoveTouchpad)
		//rb.AddForce(Vector3.right*CrossPlatformInputManager.GetAxis("Horizontal") * Speed );
		//rb.AddForce(Vector3.forward*CrossPlatformInputManager.GetAxis("Vertical") * Speed );
		
		//Debug.Log ( Speed );
		
		// Клавиатура Rigidbody
		/* if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 20);
if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 20);
if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 20);
if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 20); */
		
		
		
		//Клавиатура - без Rigidbody
		 //transform.Translate(Vector3.forward*Input.GetAxis("Vertical")*Speed.x*Time.deltaTime);
		 //transform.Translate(Vector3.right*Input.GetAxis("Horizontal")*Speed.y*Time.deltaTime);
		
		
        
    }
	
	
}
