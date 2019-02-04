using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
	
	private float progress;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		progress = progress + Time.deltaTime*1;
        transform.position = Vector3.Lerp( transform.position , new Vector3(0,-5,0), progress );
        
    }
}
