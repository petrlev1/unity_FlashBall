using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class StartGame : MonoBehaviour
{
   
   //private GameObject DualTouchControls;
   private NavMeshAgent vrag2NavMeshAgent;
   private GameObject[] VragiList;
   private GameObject canMainInt;
   private GameObject TuchLine;
   private GameObject vrag2;
   
   
    void Start()
    {	
		//timer = GameObject.Find("timer");
		
		
		canMainInt = GameObject.Find("canMainInt");
		//canMainInt.SetActive(false);
		
		Global.timer.SetActive(false);
		
		//Player = GameObject.Find("Player");
		Global.Player.SetActive(false);
		
		TuchLine = GameObject.Find("TuchLine");
		TuchLine.SetActive(false);
		
		//Global.canSetting.SetActive(false);
		
		//Vragi = GameObject.Find("vrag2");
		//Vragi.SetActive(false);
		
		//VragiList[0].SetActive(false);
		//VragiList[1].SetActive(false);
		
		//VragiList = GameObject[].Find("vrag2");
		
	
       VragiList = GameObject.FindGameObjectsWithTag("vragTag");

//Выключаем врагов
foreach(GameObject vrag in GameObject.FindGameObjectsWithTag("vragTag"))
{
    vrag.SetActive(false);
}
	
		/* foreach ( GameObject vrag in VragiList ) { 
		vrag.SetActive(false);
		} */
		
		
	gameObject.GetComponent<Canvas>().enabled = true;
	
	  
    }

    
	
	
	public void StartGameAll()
	{
		
	Global.Player.SetActive(true);
			 
			 /* foreach(GameObject vrag in GameObject.FindGameObjectsWithTag("vragTag"))
{
    vrag.SetActive(true);
} */

foreach ( GameObject vrag in VragiList ) { 
		vrag.SetActive(true);
		}
		
//Debug.Log ( "test" );
			 //canMainInt.SetActive(true);
			 //GetComponent<Canvas>().enabled = false;
			 //gameObject.GetComponent<Canvas>().enabled = false;
			 gameObject.SetActive(false);
			 //DualTouchControls.SetActive(true);
			 Global.timer.SetActive(true);
			 TuchLine.SetActive(true);
	}
	
	
	public void StartGameEasy()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 3;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 3;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 3;
			 }
	StartGameAll();	 
	}
	
	 
	public void StartGameMiddle()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 9;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 9;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 9;
			 }
	StartGameAll();		 
	}
	
	
	public void StartGameHard()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 15;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 15;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 15;
			 }
	StartGameAll();		 
	}
	
}
