using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{

    private GameObject newObject;
	
    //public Transform newPosition;
	//public GameObject myCube;
	
	void Start() {
		
		newObject = GameObject.Find("vrag2");
		
	}
    

    private void OnCollisionEnter(Collision collname)
{
	
        //Instantiate(newObject, newPosition.position, Quaternion.identity);
		
		GameObject cubeSpawn = (GameObject)Instantiate(newObject, new Vector3(0,2,0), transform.rotation);

        Debug.Log ( gameObject.name );
		
}

}
