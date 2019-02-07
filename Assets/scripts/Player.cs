using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour

{
	
	private Rigidbody rb;
	
	public float Speed = 20.0f;
	
    // Start is called before the first frame update
    void Start()
    {
		
	rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
		
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
