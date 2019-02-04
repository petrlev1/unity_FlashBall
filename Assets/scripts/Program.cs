using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    // Start is called before the first frame update
	
	float timeLeft = 5.0f;
	
	private GameObject tGameOver;
	private GameObject Player;
	
    void Start()
    {
		
		tGameOver = GameObject.Find("tGameOver");
		Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
		
    
	timeLeft -= Time.deltaTime;
	
	Debug.Log ( timeLeft );
	
         if(timeLeft < 0)
         {
             Debug.Log ( "YOU WIN !" );
         }
		 
		 if ( Player.transform.position.y < 0  ) {
			
			tGameOver.GetComponent<Canvas>().enabled = true;
			Debug.Log ( "GAME OVER" );
		}
		
        
    }
}
