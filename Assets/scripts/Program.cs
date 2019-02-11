using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* public class Global
{
    public static float GTime = 0f;
	
} */

public class Program : MonoBehaviour

{
	
    // Start is called before the first frame update
	
	//Время отсчета
	//float timeLeft = 0f;
	
	private GameObject canGameOver;
	private GameObject canWin;
	private GameObject timer;
	//private GameObject Player;
	//Text timerText;
	
    void Start()
    {
		
		//DontDestroyOnLoad(this);
		
		canGameOver = GameObject.Find("canGameOver");
		canWin = GameObject.Find("canWin");
		timer = GameObject.Find("timer");
		//Player = GameObject.Find("Player");
		
		//timerText = timer.GetComponent<Text>();
		
		

    }

    // Update is called once per frame
    void Update()
    {
		
// Отсчет времени с начала игры
	//timeLeft += Time.deltaTime;
	
	//Debug.Log ( timeLeft );

		 //Выводим секундомер на экран
		 //timerText.text = timeLeft.ToString();
		 
		 /* 
		 if( timeLeft < 0 ) { 
		 //Debug.Log ( "YOU WIN !" ); 
		 canWin.GetComponent<Canvas>().enabled = true;
		 Player.SetActive(false);
		 //timer.SetActive(false);
		 } */
		 
		 
		 
		 
	//Вылет за сцену - проигрыш	 
		 /* if ( Player.transform.position.y < -10  ) {
			canGameOver.GetComponent<Canvas>().enabled = true;
			//Debug.Log ( "GAME OVER" );
			//timeLeft = 5;
			Player.SetActive(false);
			timer.SetActive(false);
		} */
		
        
    }
	
	
	
	


}
