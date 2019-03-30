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
   //private Vector3 v3Velocity;
   //private GameObject vrag2a;
   //private GameObject vrag2Clone;
   //private GameObject[] VragiList;

    // Start is called before the first frame update
    void Start()
    {
		
		navmesh = GetComponent<NavMeshAgent>();
		border1 = GameObject.Find("border1");
		rb = GetComponent<Rigidbody>();
		
		//vrag2a = GameObject.Find("vrag2a");
		
		//VragiList = GameObject.FindGameObjectsWithTag("vragTag");
		
		//Debug.Log ( this.name );
		
		
		//Перекраска клона
		if ( this.name == "vrag2(Clone)" ) { 
		//Debug.Log ( this.name );
		GetComponent<Renderer>().material.SetColor("_Color", Color.green);
		}
		
		
		
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
		if ( transform.position.y < -10  ) {
		Destroy(gameObject);
		
		}
		
	   
		//Renderer vrag2CloneRend = vrag2Clone.GetComponent<Renderer>();
		//vrag2CloneRend.material.SetColor("_Color", Color.green);
		
		//Позиция врага
		GuardPos = this.transform.position;
		
		Speed = rb.velocity.magnitude;
		Debug.Log ( Speed );

    }
	
	//Столкновение и появление врага;
	private void OnCollisionEnter(Collision collname)
{
	
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
		
		
}

		
}
