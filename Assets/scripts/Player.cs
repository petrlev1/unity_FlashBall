using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour

{
	
	//private GameObject Player;
	private Rigidbody rb;
	
	private float Speed = 20.0f;
	private GameObject canGameOver;
	private GameObject timer;
	
    // Start is called before the first frame update
    void Start()
    {
		
	rb = GetComponent<Rigidbody>();
	
	canGameOver = GameObject.Find("canGameOver");
	timer = GameObject.Find("timer");
	
	//Debug.Log ( transform.position.y );
        
    }

    // Update is called once per frame
    void Update()
    {
		/* if ( transform.position.y < -10  ) {
		canGameOver.GetComponent<Canvas>().enabled = true;
		timer.SetActive(false);
		} */
		
		// Управление

		// Джойстик
		rb.AddForce(Vector3.right*CrossPlatformInputManager.GetAxis("Horizontal") * Speed );
		rb.AddForce(Vector3.forward*CrossPlatformInputManager.GetAxis("Vertical") * Speed );
		
		// Клавиатура Rigidbody
if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 20);
if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 20);
if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 20);
if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 20);
		
		//Клавиатура - без Rigidbody
		 //transform.Translate(Vector3.forward*Input.GetAxis("Vertical")*Speed.x*Time.deltaTime);
		 //transform.Translate(Vector3.right*Input.GetAxis("Horizontal")*Speed.y*Time.deltaTime);
		
		
        
    }
}
