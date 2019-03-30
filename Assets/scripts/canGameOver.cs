using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canGameOver : MonoBehaviour
{
	
	private GameObject canWin;
	
	void Start()
	
	{
		canWin = GameObject.Find("canWin");
	
	//scoreNum = PlayerPrefs.GetFloat("scoreNumKey");
	//Debug.Log ( scoreNum );
	
	}
	
	void Update()
	{
		
		if ( Global.Player.transform.position.y < -10  ) {
		GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		canWin.SetActive(false);
		
		}
		
	
		
	}
	
    // Перезагрузка игры
	public void ReloadGame () 
	{ 
	
             Application.LoadLevel(1);
			 //Global.DualTouchControls.SetActive(false);
			 
			 
	}
	
}
