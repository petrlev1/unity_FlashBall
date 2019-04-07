using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canMainInt : MonoBehaviour
{
	
	public GameObject ic_redVrag;
	public GameObject ic_redVragText;
	public GameObject flash1;
	
	void Awake()
	{
		flash1.SetActive(false);
	}
	
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {	
		
		//Вызываем событие скидывания всех красных мячей
		if ( Global.VragList.Length == 0 && Global.Player.transform.position.y < 5 )
		{
			//Звуковой эффект из массива AudioSource
			AudioSource[] audios = Global.sfx.GetComponents<AudioSource>();
		    audios[0].enabled = true;
			
			//Убираем счет красных мячей
			ic_redVrag.GetComponent<Image>().enabled = false;
		ic_redVragText.GetComponent<Text>().enabled = false;
		flash1.SetActive(true);
			
		} 			
		
//Debug.Log ( "Red: " + Global.VragList.Length );
        
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
