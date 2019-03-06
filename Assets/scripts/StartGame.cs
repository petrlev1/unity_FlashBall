using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class StartGame : MonoBehaviour
{
   
   //private GameObject DualTouchControls;
   private NavMeshAgent vrag2NavMeshAgent;
   public GameObject[] VragiList;
   private GameObject canMainInt;
   private GameObject TuchLine;
   
   
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
		
		foreach ( GameObject vrag in VragiList ) { 
		vrag.SetActive(false);
		}
		
		//DualTouchControls = GameObject.Find("DualTouchControls");
		//Global.DualTouchControls.GetComponent<Canvas>().enabled = false;

    //x.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
	//x.SetActive(false);
	//Debug.Log ( t1.name );
	gameObject.GetComponent<Canvas>().enabled = true;
	
	  
    }

    
    void Update()
    {
		
		
        
    }
	
	public void StartGameAll()
	{
	Global.Player.SetActive(true);
			 
			 foreach ( GameObject vrag in VragiList ) { vrag.SetActive(true); }
			 //canMainInt.SetActive(true);
			 //GetComponent<Canvas>().enabled = false;
			 gameObject.GetComponent<Canvas>().enabled = false;
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
