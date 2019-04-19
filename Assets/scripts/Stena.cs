using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stena : MonoBehaviour
{
    
	public int AnimSpeed = -5;
	
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		
		transform.position += new Vector3(0, AnimSpeed * Time.deltaTime, 0);
		
		if ( transform.position.y < -5 ) { Destroy(gameObject); }
        
    }
}
