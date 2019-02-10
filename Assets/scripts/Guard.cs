using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
	
   private GameObject player;
   private NavMeshAgent navmesh;

    // Start is called before the first frame update
    void Start()
    {
		
		navmesh = GetComponent<NavMeshAgent>();
		
		player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
		
		navmesh.destination = player.transform.position;

    }
}
