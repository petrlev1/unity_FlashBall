using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
	
	
	
    private void OnCollisionEnter(Collision collision)
{
        Debug.Log ( gameObject.name );
}

}
