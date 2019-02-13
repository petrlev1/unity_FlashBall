using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canGameOver : MonoBehaviour
{
	
	void Start()
	
	{
	
	
	}
	
	void Update()
	{
		
		if ( Global.Player.transform.position.y < -10  ) {
		GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		//Debug.Log ( "GAME OVER" );
		
		}
		
		
	}
	
    // Перезагрузка игры
	public void ReloadGame () 
	{ 
	
             Application.LoadLevel(0); 
			 
	}
	
}
