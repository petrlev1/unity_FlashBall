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
	
    void Start()
    {
		
		tYouScore = GameObject.Find("tYouScore");
	    tYouScoreText = tYouScore.GetComponent<Text>();
		timerText = GetComponent<Text>();
        
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
	}
	
	/* public static Timer1()
	{ 
	  timeLeft += Time.deltaTime;
	  //Debug.Log ( timeLeft.ToString() );
	  return timeLeft;
	  
	} */
	
	
}
