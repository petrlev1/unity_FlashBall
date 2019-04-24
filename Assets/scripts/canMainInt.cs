using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canMainInt : MonoBehaviour
{
	
	public GameObject ic_redVrag;
	public GameObject ic_redVragText;
	public GameObject ic_redVragTextMax;
	public GameObject flash1;
	private int ScoreNum = 0;
	public GameObject Score;
	private GameObject[] VragList;
	private GameObject CanStart;
	
	
    void OnGUI()
	{
	
	//Выводим очки на экран
		 Score.GetComponent<Text>().text = ScoreNum.ToString();
	}
	
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
	
	CanStart = GameObject.Find("CanStart2");
	
	VragList = GameObject.FindGameObjectsWithTag("vragTag");
	
	//Подсчет очков скинутых шаров
	foreach ( GameObject vrag in VragList )
	{
		if ( vrag.transform.position.y < -10 ) { ScoreNum += 2; }
	}
	
	foreach ( GameObject vrag in Global.VragListClone )
	{
		if ( vrag.transform.position.y < -10 ) { ScoreNum++; }
	} 
	
	PlayerPrefs.SetInt("ScoreNumKey2", ScoreNum);
		
		//Вызываем событие скидывания всех красных мячей
		if ( VragList.Length == 0 && Global.Player.transform.position.y < 5 && CanStart != true )
		{
			//Звуковой эффект из массива AudioSource
			AudioSource[] audios = Global.sfx.GetComponents<AudioSource>();
		    audios[0].enabled = true;
			
			//Убираем счет красных мячей
			ic_redVrag.GetComponent<Image>().enabled = false;
		ic_redVragText.GetComponent<Text>().enabled = false;
		ic_redVragTextMax.GetComponent<Text>().enabled = false;
		flash1.SetActive(true);
			
		} 			
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
