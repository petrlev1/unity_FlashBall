using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canWin : MonoBehaviour
{
	
    void Start()
    {
        //Debug.Log ( Global.VragList );
		
    }

    // Update is called once per frame
    void Update()
    {
		
		//Определяем отсутствие врагов и расположение игрока для показа выиграша
		if ( Global.VragList.Length == 0 && Global.Player.transform.position.y < 5 )
		{
			//Debug.Log ( "You Win" );
			//Application.LoadLevel(0);
			GetComponent<Canvas>().enabled = true;
			Global.timer.SetActive(false);
		    Global.Player.SetActive(false);
		}
		
		//Debug.Log ( Global.VragClone );
		
		/* foreach(GameObject vrag in Global.VragList)
		{

		} */
        
    }
	
}
