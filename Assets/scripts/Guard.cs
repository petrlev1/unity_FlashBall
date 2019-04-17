using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{

   private NavMeshAgent navmesh;
   private GameObject border1;
   private Vector3 GuardPos;
   private Rigidbody rb;
   private float Speed;
   //public int DeadVragNum = 0;
   
   //Источник звуков
	sfx AudioSource;
	

    void Start()
    {
		
		navmesh = GetComponent<NavMeshAgent>();
		border1 = GameObject.Find("border1");
		rb = GetComponent<Rigidbody>();
		
		//vrag2a = GameObject.Find("vrag2a");
		
		//VragiList = GameObject.FindGameObjectsWithTag("vragTag");
		
		//Debug.Log ( this.name );
		
		
		//Перекраска клона и присвоение ему тэга
		if ( this.name == "vrag2(Clone)" ) { 
		//Debug.Log ( this.name );
		GetComponent<Renderer>().material.SetColor("_Color", Color.green);
		this.tag = "vragTagClone";
		}
		
		//Debug.Log ( this.tag );
		
		/* if ( GameObject = "vrag2(Clone)" ) {
		
		foreach(GameObject vrag in VragiList)
{
        Renderer vragRend = vrag.GetComponent<Renderer>();
		vragRend.material.SetColor("_Color", Color.green);
}

		} */
		//VragiList.GetComponent<Renderer>().enabled = false;
		
	   //vrag2Clone = GameObject.Find("vrag2(Clone)");
	   //Renderer VragiListRend = VragiList.GetComponent<Renderer>();
		
		/* foreach(GameObject vrag in GameObject.FindGameObjectsWithTag("vragTag"))
{
	//vrag2CloneRend.material.SetColor("_Color", Color.green);
} */

//Instantiate(GameObject.Find("vrag2"), new Vector3 (0, 10, 0), transform.rotation);
//Debug.Log ( "test11" );
        
    }

    // Update is called once per frame
    void Update()
    {
		
		//Rigidbody rb = GetComponent<Rigidbody>();
		//Vector3 v3Velocity = rb.velocity;
		//Debug.Log ( v3Velocity );
		
		//Установление цели
		navmesh.destination = Global.Player.transform.position;
		
		//Удаление ненужных объектов
		if ( transform.position.y < -10  ) 
		{
		
        //Звук
if ( this.name == "vrag2(Clone)" ) {		
		AudioSource = Global.sfx.GetComponent<sfx>();
	    AudioSource.joke1.Play(); 
} else {
	AudioSource = Global.sfx.GetComponent<sfx>();
	AudioSource.joke1Red.Play();
}
		

//Удаление объекта
		Destroy(gameObject);
		}
		
		
		
	   
		//Renderer vrag2CloneRend = vrag2Clone.GetComponent<Renderer>();
		//vrag2CloneRend.material.SetColor("_Color", Color.green);
		
		//Позиция врага
		GuardPos = this.transform.position;
		
		Speed = rb.velocity.magnitude;
		//Debug.Log ( Speed );
		
		

    }
	
	
	private void OnCollisionEnter(Collision collname)
{
	//Столкновение и появление врага;
		if( collname.gameObject.name == "Player" && gameObject.name == "vrag2"  ) {
			
			//vrag2a.SetActive(true);
			//vrag2a.GetComponent<Renderer>().enabled = true;
			
			//Дублирование нового врага
		Instantiate(GameObject.Find("vrag2"), GuardPos, transform.rotation);
		
		//Debug.Log ( Global.Player.transform.position );
		}
		
		//отключение преследования
		if( collname.gameObject.name == "border1" && Speed > Global.vragSpeed ) {
		
		navmesh.enabled = false;
		//Debug.Log ( "COOL" );
		
		}
		
		if (this.name == "vrag2(Clone)" ) { navmesh.enabled = false; }
		
		
}

		
}
