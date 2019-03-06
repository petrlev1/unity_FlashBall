using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControl_Tuch : MonoBehaviour
{
    private Rigidbody rb;
	
	public float Speed = 20.0f;
	
    void Start()
    {
		
		rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
		
		rb.AddForce(Vector3.right*CrossPlatformInputManager.GetAxis("Horizontal") * Speed );
		rb.AddForce(Vector3.forward*CrossPlatformInputManager.GetAxis("Vertical") * Speed );
        
    }
}
