using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{

    public GameObject newObject;
    //public Transform newPosition;

	//public GameObject myCube;
    public Vector3 spawnSpot = new Vector3(0,2,0);
    

    private void OnCollisionEnter(Collision collision)
{
        //Instantiate(newObject, newPosition.position, Quaternion.identity);
		
		GameObject cubeSpawn = (GameObject)Instantiate(newObject, new Vector3(0,2,0), transform.rotation);

        Debug.Log ( gameObject.name );
		
}

}
