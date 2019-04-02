using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canMainInt : MonoBehaviour
{
	
    void Start()
    {
        
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		
//Debug.Log ( "Red: " + Global.VragList.Length );
//Debug.Log ( "Clone: " + Global.VragListClone.Length );
        
    }
	
	//Кнопка настроек
	public void butSetting () 
	{ 
	
	     Global.canSetting.SetActive(true);
		 Global.canSetting.GetComponent<Canvas>().enabled = true;
		 
		 Time.timeScale = 0;
	
         //Debug.Log ( "butSetting" );
			 
	}
	
	
}
