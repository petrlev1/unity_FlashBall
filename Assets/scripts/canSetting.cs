using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canSetting : MonoBehaviour
{
    
	private GameObject ToggelAkcel;
	Toggle ToggelAkcel2;
	
	private GameObject Player;
	PlayerControl_Keyboard PlayerControl_KeyboardScript;
	PlayerControl_Akcel PlayerControl_AkcelScript;
	
	
    void Start()
    {
		
	ToggelAkcel = GameObject.Find("ToggelAkcel");
	ToggelAkcel2 = ToggelAkcel.GetComponent<Toggle>();
	
	Player = GameObject.Find("Player");
	
	PlayerControl_KeyboardScript = Player.gameObject.GetComponent<PlayerControl_Keyboard>();
	PlayerControl_AkcelScript = Player.gameObject.GetComponent<PlayerControl_Akcel>();
	
	//GetComponent<Canvas>().enabled = false;
	
	//ToggelAkcel.SetActive(false);
        
    }


    void Update()
    {
		
		//Включение/отключение клавиатурного управления игрока
		if ( ToggelAkcel2.isOn == false ) { 
		PlayerControl_AkcelScript.enabled = !PlayerControl_AkcelScript.enabled;
		} else { PlayerControl_AkcelScript.enabled = true; }
		
        
    }
	
	public void ReturnToGame () 
	{ 
	
	Global.canSetting.GetComponent<Canvas>().enabled = false;
	Time.timeScale = 1f;
      
			 
	}
	
}
