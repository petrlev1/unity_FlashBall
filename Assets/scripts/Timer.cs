using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 0f;
	private GameObject timer;
	Text timerText;
	private GameObject tYouScore;
	Text tYouScoreText;
	public float scoreNum;
	private float scoreNum2;
	private GameObject tNewRecord;
	//Text tNewRecordText;
	
    void Start()
    {
		//переменная с сохраненным временем
		scoreNum = PlayerPrefs.GetFloat("scoreNumKey");
		
		if ( scoreNum == 0 ) { 
		scoreNum = 1000000f;
		PlayerPrefs.SetFloat("scoreNumKey", 1000000f);
PlayerPrefs.Save();
//Debug.Log ( "scoreNum: 0" );
		}
		//if ( scoreNum == 0 ) { Debug.Log ( "SN 0: " + scoreNum ); }
		
		//Debug.Log ( scoreNum );
		
		
		tNewRecord = GameObject.Find("tNewRecord");
		//tNewRecordText = tNewRecord.GetComponent<Text>();
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
		timeLeft += Time.deltaTime;
		
		timerText = GetComponent<Text>();
		timerText.text = timeLeft.ToString();
		
		//Debug.Log ( timeLeft.ToString() );
		
		
		//Debug.Log ( scoreNum );
		
    }
	
	
	//Выводит достигнутое время
	void OnDisable()
	{
		
		//Если новое время больше - выводим и сохраняем новое
		if ( timeLeft < scoreNum && Global.Player.transform.position.y > 0 && Global.VragList.Length == 0 && Global.VragListClone.Length == 0 ) { 
		
		//Debug.Log ( "timeLeft: " + timeLeft );
		
		PlayerPrefs.SetFloat("scoreNumKey", timeLeft);
		PlayerPrefs.Save();
		
		
		} else {
			//PlayerPrefs.SetFloat("scoreNumKey", scoreNum);
			PlayerPrefs.SetFloat("scoreNumKey", scoreNum);
			
		}
		
		
		
		//Debug.Log ( Global.VragList.Length + " " + Global.VragListClone.Length );
		
		
	    //Debug.Log(timeLeft);
		
		//включение строки о новом рекорде
		//tNewRecord.GetComponent<Text>().enabled = true;

	
		
		/* tYouScore = GameObject.Find("tYouScore");
	    tYouScoreText = tYouScore.GetComponent<Text>();
		tYouScoreText.text = timeLeft.ToString(); */

		
	}
	
	/* public static Timer1()
	{ 
	  timeLeft += Time.deltaTime;
	  //Debug.Log ( timeLeft.ToString() );
	  return timeLeft;
	  
	} */
	
	
}
