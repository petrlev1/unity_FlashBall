using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeLeft = 0f;
	private GameObject timer;
	Text timerText;
	private GameObject tYouScore;
	Text tYouScoreText;
	private float scoreNum;
	private float scoreNum2;
	private GameObject tNewRecord;
	//Text tNewRecordText;
	
    void Start()
    {
		
		tYouScore = GameObject.Find("tYouScore");
	    tYouScoreText = tYouScore.GetComponent<Text>();
		timerText = GetComponent<Text>();
		
		tNewRecord = GameObject.Find("tYouScore");
		
		//переменная с сохраненным временем
		scoreNum = PlayerPrefs.GetFloat("scoreNumKey");
		//Debug.Log ( scoreNum );
		
		
		tNewRecord = GameObject.Find("tNewRecord");
		//tNewRecordText = tNewRecord.GetComponent<Text>();
		
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		timeLeft += Time.deltaTime;
		timerText.text = timeLeft.ToString();
		//Debug.Log ( timeLeft.ToString() );
    }
	
	
	//Выводит достигнутое время
	void OnDisable()
	{
		
		tYouScoreText.text = timeLeft.ToString();
		
		//Если новое время больше - выводим и сохраняем новое
		if ( timeLeft > scoreNum ) { 
		
		PlayerPrefs.SetFloat("scoreNumKey", timeLeft);
	    //Debug.Log(timeLeft);
		
		//включение строки о новом рекорде
		tNewRecord.GetComponent<Text>().enabled = true;

		}
		
		
		
	}
	
	/* public static Timer1()
	{ 
	  timeLeft += Time.deltaTime;
	  //Debug.Log ( timeLeft.ToString() );
	  return timeLeft;
	  
	} */
	
	
}
