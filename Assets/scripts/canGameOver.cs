using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canGameOver : MonoBehaviour
{
	
	//public float scoreNum;
	
	void Start()
	
	{
	
	//scoreNum = PlayerPrefs.GetFloat("scoreNumKey");
	//Debug.Log ( scoreNum );
	
	}
	
	void Update()
	{
		
		if ( Global.Player.transform.position.y < -10  ) {
		GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		
		}
		
		
	}
	
    // Перезагрузка игры
	public void ReloadGame () 
	{ 
	
             Application.LoadLevel(0);
			 //Global.DualTouchControls.SetActive(false);
			 
			 
	}
	
}
