using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
	
    //public Transform newPosition;
	//public GameObject myCube;
	
    

    private void OnCollisionEnter(Collision collname)
{
	
        //Instantiate(newObject, newPosition.position, Quaternion.identity);
		
		if( collname.gameObject.name == "vrag2" || collname.gameObject.name == "vrag2(Clone)" ) {
			
		Instantiate(GameObject.Find("vrag2"), new Vector3(0,2,0), transform.rotation);

        Debug.Log ( gameObject.name );
		
		}
		
}

}
