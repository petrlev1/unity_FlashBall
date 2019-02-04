using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    // Start is called before the first frame update
	
	float timeLeft = 5.0f;
	
	private GameObject Canvas;
	private GameObject Player;
	
    void Start()
    {
		
		Canvas = GameObject.Find("Canvas");
		Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
		
    
	
	
	
// Отсчет времени с начала игры
	timeLeft -= Time.deltaTime;
	
	Debug.Log ( timeLeft );
	
         if(timeLeft < 0) { Debug.Log ( "YOU WIN !" ); }
		 
		 
		 
		 
		 
	//Вылет за сцену - проигрыш	 
		 if ( Player.transform.position.y < 0  ) {
			Canvas.GetComponent<Canvas>().enabled = true;
			Debug.Log ( "GAME OVER" );
		}
		
        
    }
	
	
	// Перезагрузка игры
	
	public void ReloadGame () 
	{ 
             Application.LoadLevel(0); 
			 
	}
	


}
