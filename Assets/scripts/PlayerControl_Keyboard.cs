using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Keyboard : MonoBehaviour
{
	
    private Rigidbody rb;
	
	//PlayerControl_Keyboard KeyboardScript;
	
    void Start()
    {
		
		rb = GetComponent<Rigidbody>();
		
		//KeyboardScript = gameObject.GetComponent<PlayerControl_Keyboard>();
		//KeyboardScript.enabled = !KeyboardScript.enabled;
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 20);
if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 20);
if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 20);
if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 20);
        
    }
	
}
