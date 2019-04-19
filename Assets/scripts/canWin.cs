using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canWin : MonoBehaviour
{

//Источник звуков
	sfx AudioSource;
	
	private GameObject tYouScore;
	Text tYouScoreText;
	private GameObject tBestScore;
	Text tBestScoreText;
	public  GameObject timer;
	public GameObject newRecord;
	Timer timerScript;
	Text timerText;
	Text scoreNumText;
	private GameObject[] VragiList;
	private GameObject[] VragListClone;
	public GameObject ScoreText;
	
	void OnGUI()
	{
	//Выводим очки на экран
	ScoreText.GetComponent<Text>().text = PlayerPrefs.GetInt("ScoreNumKey2").ToString();
	}
	
    void Start()
    {
		/* //Звук выигрыша
		AudioSource = Global.sfx.GetComponent<sfx>();
	    AudioSource.victory.Play(); */
		
		tYouScore = GameObject.Find("tYouScore");
		tYouScoreText = tYouScore.GetComponent<Text>();
		
		tBestScore = GameObject.Find("tBestScore");
		tBestScoreText = tBestScore.GetComponent<Text>();
		
		timerText = timer.GetComponent<Text>();
		
		timerScript = timer.GetComponent<Timer>();
		//tYouScoreText.text = timerScript.scoreNum.ToString();
		
		tYouScoreText.text = "Time: " + timerText.text;
		tBestScoreText.text = "Best time: " + timerScript.scoreNum.ToString();
		
		if ( timerScript.timeLeft < timerScript.scoreNum ) { newRecord.GetComponent<Image>().enabled = true; }
		//scoreNumText = timerScript.scoreNum;
		
		//Debug.Log ( timerScript.scoreNum );
		
		//timerText.text = timer.GetComponent<Text>();
	
		//Global.canWin.SetActive(true);
		
		//sfx = GameObject.Find("sfx");
		//Debug.Log ( "WINN" );
		
    }
	
	void Update()
	{
		VragiList = GameObject.FindGameObjectsWithTag("vragTag");
		VragListClone = GameObject.FindGameObjectsWithTag("vragTagClone");
		
		if ( VragiList.Length == 0 && VragListClone.Length == 0 && Global.Player.transform.position.y < 5 )
		{
		//Application.LoadLevel(0);
	        Global.canWin.SetActive(true);
			GetComponent<Canvas>().enabled = true;
			Global.timer.SetActive(false);
		    Global.Player.SetActive(false);
			
			//Звук выигрыша
			AudioSource[] audios = Global.sfx.GetComponents<AudioSource>();
		    audios[3].enabled = true;
		}
	}
	
	
	//Функция выигрыша
	/* public void canWinFunc()
	{
			if ( Global.VragList.Length == 0 && Global.VragListClone.Length == 0 && Global.Player.transform.position.y < 5 )
		{
		//Application.LoadLevel(0);
	        Global.canWin.SetActive(true);
			GetComponent<Canvas>().enabled = true;
			Global.timer.SetActive(false);
		    Global.Player.SetActive(false);
		}
			
	} */
	
}
