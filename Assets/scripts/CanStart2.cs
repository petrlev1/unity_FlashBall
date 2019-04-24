using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class CanStart2 : MonoBehaviour
{
	
	public GameObject Score;
	public GameObject ic_redVrag;
	//public GameObject ic_redVragText;
	public GameObject ic_greenVrag;
	public GameObject Stena;
	private NavMeshAgent vrag2NavMeshAgent;
	public GameObject RadioEasy;
	public GameObject RadioMiddle;
	public GameObject RadioHard;
	public GameObject butSetting;
	
	sfx AudioSource;
	
	
	void Awake()
    {
		Score.SetActive(false);
		ic_redVrag.SetActive(false);
		//ic_redVragText.SetActive(false);
		ic_greenVrag.SetActive(false);
		butSetting.SetActive(false);
	}

    void Start()
    {
		
		//RadioHardTog = RadioHard.GetComponent<Toggle>();
	
	//Выключаем врагов
foreach( GameObject vrag in Global.VragList )
{
    vrag.SetActive(false);
}
        
}


    // Update is called once per frame
    void Update()
    {
	
	//VragiList = GameObject.FindGameObjectsWithTag("vragTag");
	
        
    }
	
//Старт игры - кнопка GO
public void StartGameAll2()
	{

		foreach( GameObject vrag in Global.VragList )
		
{
	
    vrag.SetActive(true);
	
	//Переключение режимов сложности
	if ( RadioEasy.GetComponent<Toggle>().isOn == true ) {
	vrag.GetComponent<NavMeshAgent>().speed = 6;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 6;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 6;
			 Global.vragSpeed = 1f;
	}
	
	if ( RadioMiddle.GetComponent<Toggle>().isOn == true ) {
	vrag.GetComponent<NavMeshAgent>().speed = 9;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 9;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 9;
			 Global.vragSpeed = 3f;
	}
	
	if ( RadioHard.GetComponent<Toggle>().isOn == true ) {
	vrag.GetComponent<NavMeshAgent>().speed = 14;
		     vrag.GetComponent<NavMeshAgent>().angularSpeed = 14;
		     vrag.GetComponent<NavMeshAgent>().acceleration = 14;
			 Global.vragSpeed = 7f;
	}
}

Score.SetActive(true);
ic_redVrag.SetActive(true);
//ic_redVragText.SetActive(true);
ic_greenVrag.SetActive(true);
Stena.GetComponent<Stena>().enabled = true;
Global.canWin.SetActive(true);
butSetting.SetActive(true);

AudioSource = Global.sfx.GetComponent<sfx>();
AudioSource.open1.Play();

gameObject.SetActive(false);

//Global.canWin.SetActive(true);
//Debug.Log ( "test" );

}

	
}
