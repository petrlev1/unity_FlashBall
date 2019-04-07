using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canSetting : MonoBehaviour
{
    
	private GameObject ToggelAkcel;
	private GameObject ToggelTuch;
	Toggle ToggelAkcel2;
	Toggle ToggelTuch2;
	
	private GameObject Player;
	PlayerControl_Keyboard PlayerControl_KeyboardScript;
	PlayerControl_Akcel PlayerControl_AkcelScript;
	PlayerControl_Tuch PlayerControl_TuchScript;
	
	private int toggleAkcelKey1;
	private int toggleSwipeKey1;
	
	
    void Start()
    {
		
	//PlayerControl_AkcelScript = Global.Player.gameObject.GetComponent<PlayerControl_Akcel>();
	//PlayerControl_AkcelScript.enabled = false;
		
	ToggelAkcel = GameObject.Find("ToggelAkcel");
	ToggelAkcel2 = ToggelAkcel.GetComponent<Toggle>();
	
	ToggelTuch = GameObject.Find("ToggelSwipe");
	ToggelTuch2 = ToggelTuch.GetComponent<Toggle>();
	
	Player = GameObject.Find("Player");
	
	PlayerControl_KeyboardScript = Player.gameObject.GetComponent<PlayerControl_Keyboard>();
	PlayerControl_AkcelScript = Player.gameObject.GetComponent<PlayerControl_Akcel>();
	PlayerControl_TuchScript = Player.gameObject.GetComponent<PlayerControl_Tuch>();
	
	//GetComponent<Canvas>().enabled = false;
	//ToggelAkcel.SetActive(false);
	
	
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
	


    void Update()
    {
		
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
		
	//Включение/отключение акселерометра
		/* if ( ToggelAkcel2.isOn == false ) { 
		PlayerControl_AkcelScript.enabled = !PlayerControl_AkcelScript.enabled;
		} else { PlayerControl_AkcelScript.enabled = true; }
		
		//Включение/отключение свайпа
		if ( ToggelTuch2.isOn == false ) { 
		PlayerControl_TuchScript.enabled = !PlayerControl_TuchScript.enabled;
		} else { PlayerControl_TuchScript.enabled = true; } */
        
    }
	
/* public void ToggleAudio() {
	if ( ToggelAkcel2.isOn == false ) { 
		PlayerControl_AkcelScript.enabled = !PlayerControl_AkcelScript.enabled;
		} else { PlayerControl_AkcelScript.enabled = true; }
		
	Debug.Log ("toggleAudio");
} */

/* void ToggleValueChanged(Toggle change)
{
		PlayerControl_AkcelScript.enabled = !PlayerControl_AkcelScript.enabled;
} */	
        
	
	public void ReturnToGame () 
	{ 
	
	Global.canSetting.GetComponent<Canvas>().enabled = false;
	Global.canSetting.SetActive(false);
	Time.timeScale = 1f;
      
			 
	}
	
}
