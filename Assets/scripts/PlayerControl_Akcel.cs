using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Akcel : MonoBehaviour
{
	
    //private Rigidbody rb;
	
	public int acceleration;
	public float force = 10.0f;
	
    void Start()
    {
		
		//rb = GetComponent<Rigidbody>();
		
		//KeyboardScript = gameObject.GetComponent<PlayerControl_Keyboard>();
		//KeyboardScript.enabled = !KeyboardScript.enabled;
        
    }

    // Update is called once per frame
    void Update()
    {
		
		Vector3 dir = Vector3.zero;
            dir.x = Input.acceleration.x;
            dir.z = Input.acceleration.y;
			//Debug.Log ( dir.z );

			//Корректировка чувствительности наклона по y
			//if (dir.z > -0.57f ) { 
			 if (dir.z > -0.85f ) {
			dir.z = dir.z + 0.8f;
			} 

			
            if (dir.sqrMagnitude > 1) dir.Normalize();
            dir *= Time.deltaTime;
			GetComponent<Rigidbody>().AddForce( (dir.x*force)*acceleration, 0, (dir.z * force) * acceleration, ForceMode.Force);
        
    }
	
}
