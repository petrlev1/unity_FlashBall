using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canGameOverStudy : MonoBehaviour
{
	
	private GameObject canWin;
	
	//Источник звуков
	sfx AudioSource;
	
	void Start()
	
	{
		canWin = GameObject.Find("canWin");
		Global.canMainInt.SetActive(false);
	
	//Звук проигрыша
		AudioSource = Global.sfx.GetComponent<sfx>();
	    AudioSource.gameover.Play();

	
	//scoreNum = PlayerPrefs.GetFloat("scoreNumKey");
	//Debug.Log ( scoreNum );
	
	}
	
	public void GameOverFunc()
	{
		if ( Global.Player.transform.position.y < -10  ) {
		Global.canGameOver.SetActive(true);
		Global.canGameOver.GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		canWin.SetActive(false);
	}
	}
	
	
    // Перезагрузка игры
	public void ReloadGame () 
	{ 
	
             Application.LoadLevel("stud100");
			 //Global.canMainInt.SetActive(true);
			 //Global.DualTouchControls.SetActive(false);	 
			 
	}
	
}
