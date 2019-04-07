using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   
   //private GameObject DualTouchControls;
   private NavMeshAgent vrag2NavMeshAgent;
   private GameObject[] VragiList;
   private GameObject canMainInt;
   private GameObject TuchLine;
   private GameObject vrag2;
   
   
   private GameObject ToggelAkcel;
	private GameObject ToggelTuch;
	Toggle ToggelAkcel2;
	Toggle ToggelTuch2;
   
   private int toggleAkcelKey1;
	private int toggleSwipeKey1;
	
	//private float scoreNum2;
	
	PlayerControl_Akcel PlayerControl_AkcelScript;
	PlayerControl_Tuch PlayerControl_TuchScript;
	
	//sfx AudioSource;
   
   
    void Start()
    {	
	
	
	/* PlayerPrefs.SetFloat("scoreNumKey2", 5000f);
	scoreNum2 = PlayerPrefs.GetFloat("scoreNumKey2");
	//PlayerPrefs.Save();
	  Debug.Log ( scoreNum2 ); */
	  
	
	//AudioSource = Global.sfx.GetComponent<sfx>();
	//AudioSource.victory.Play();
		
		
		canMainInt = GameObject.Find("canMainInt");
		//canMainInt.SetActive(false);
		
		Global.timer.SetActive(false);
		
		//Player = GameObject.Find("Player");
		Global.Player.SetActive(false);
		
		TuchLine = GameObject.Find("TuchLine");
		TuchLine.SetActive(false);
		
		Global.canSetting.SetActive(false);
		
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
	
	Global.canMainInt.SetActive(false);
	
	
	PlayerControl_AkcelScript = Global.Player.gameObject.GetComponent<PlayerControl_Akcel>();
	PlayerControl_TuchScript = Global.Player.gameObject.GetComponent<PlayerControl_Tuch>();
	
	ToggelAkcel = GameObject.Find("ToggelAkcelStart");
	ToggelAkcel2 = ToggelAkcel.GetComponent<Toggle>();
	
	ToggelTuch = GameObject.Find("ToggelSwipeStart");
	ToggelTuch2 = ToggelTuch.GetComponent<Toggle>();
	
	//Переменная для контроля кнопок управления
	toggleAkcelKey1 = PlayerPrefs.GetInt("toggleAkcelKey");
	toggleSwipeKey1 = PlayerPrefs.GetInt("toggleSwipeKey");
	//Контроль кнопок управления
	if ( toggleAkcelKey1 == 1 ) {
			ToggelAkcel2.isOn = false;
			PlayerControl_AkcelScript.enabled = false;
		} else { 
		ToggelAkcel2.isOn = true; 
		PlayerControl_AkcelScript.enabled = true;
		}
		
	if ( toggleSwipeKey1 == 1 ) {
			ToggelTuch2.isOn = false;
			PlayerControl_TuchScript.enabled = false;
		} else { 
		ToggelTuch2.isOn = true; 
		PlayerControl_TuchScript.enabled = true;
		}
		
	  
    }
	
	//Управление акселерометром
	public void Akcel() {
	
	//PlayerControl_AkcelScript = Global.Player.gameObject.GetComponent<PlayerControl_Akcel>();
	//Debug.Log ( toggle.isOn );
	if ( ToggelAkcel2.isOn == false ) {
		PlayerPrefs.SetInt("toggleAkcelKey", 1);
		PlayerControl_AkcelScript.enabled = false;
		} else { 
		PlayerPrefs.SetInt("toggleAkcelKey", 0);
		PlayerControl_AkcelScript.enabled = true;
		}
		
	}
	
	//Управление свайпом
	public void Swipe() {
	
	//PlayerControl_TuchScript = Player.gameObject.GetComponent<PlayerControl_Tuch>();
	//Debug.Log ( toggle.isOn );
	if ( ToggelTuch2.isOn == false ) {
		PlayerPrefs.SetInt("toggleSwipeKey", 1);
		PlayerControl_TuchScript.enabled = false;
		} else { 
		PlayerPrefs.SetInt("toggleSwipeKey", 0);
		PlayerControl_TuchScript.enabled = true;
		}
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
			 Global.canMainInt.SetActive(true);
			 Global.canSetting.SetActive(true);
			 
	}
	
	
	public void StartGameEasy()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 6;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 6;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 6;
			 Global.vragSpeed = 2f;
			 }
	StartGameAll();	 
	}
	
	 
	public void StartGameMiddle()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 9;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 9;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 9;
			 Global.vragSpeed = 5f;
			 }
	StartGameAll();		 
	}
	
	
	public void StartGameHard()
	{ 
	foreach ( GameObject vrag in VragiList ) {
             vrag.GetComponent<NavMeshAgent>().speed = 15;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 15;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 15;
			 Global.vragSpeed = 10f;
			 }
	StartGameAll();		 
	}
	
}
