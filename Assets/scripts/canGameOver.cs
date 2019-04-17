using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canGameOver : MonoBehaviour
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
	
	void Update()
	{
		//Debug.Log ( Global.VragList.Length );
	}
	
	/* public void GameOverFunc()
	{
		if ( Global.Player.transform.position.y < -10 || Global.VragList.Length > 5  ) {
		Global.canGameOver.SetActive(true);
		Global.canGameOver.GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		canWin.SetActive(false);
	}
	} */
	
	
    // Перезагрузка игры
	public void ReloadGame () 
	{ 
	
             Application.LoadLevel(0);
			 //Global.canMainInt.SetActive(true);
			 //Global.DualTouchControls.SetActive(false);	 	 
	}
	
	public void ReloadGameStud100 () 
	{ 
	
             Application.LoadLevel("stud100");
			 //Global.canMainInt.SetActive(true);
			 //Global.DualTouchControls.SetActive(false);	 	 
	}
	
	//GameOver
   public void GameOverFunc()
	{
		if ( Global.Player.transform.position.y < -10 || Global.VragList.Length > 30  ) {
		Global.canGameOver.SetActive(true);
		Global.canGameOver.GetComponent<Canvas>().enabled = true;
		Global.timer.SetActive(false);
		Global.Player.SetActive(false);
		Global.canWin.SetActive(false);
		Time.timeScale = 0;
	}
	}
	
	void OnDisable()
	{ Time.timeScale = 1f; }
	
}
