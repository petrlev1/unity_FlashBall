using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{

   private NavMeshAgent navmesh;

    // Start is called before the first frame update
    void Start()
    {
		
		navmesh = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
		
		navmesh.destination = Global.Player.transform.position;

    }
	
	//Столкновение и появление врага;
	private void OnCollisionEnter(Collision collname)
{
	
		if( collname.gameObject.name == "Player" ) {
		Instantiate(GameObject.Find("vrag2"), new Vector3(0,2,0), transform.rotation);
		
		}
		
}
		
}
