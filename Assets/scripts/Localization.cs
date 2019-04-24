using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localization : MonoBehaviour
{
	
	public GameObject Text_Mission;
	public GameObject infoText;
	public GameObject RadioEasyText;
	public GameObject RadioMiddleText;
	public GameObject RadioHardText;
	public GameObject Button_GOText;
	public GameObject butReloadText;
	public GameObject butReloadWinText;
	public GameObject ScoreGOText;
	public GameObject ScoreWinText;
	public GameObject ic_redVragTextMax;
	public GameObject ic_greenVragTextMax;
	public GameObject controlText;
	public GameObject controlAkcelText;
	public GameObject controlSwipeText;

    void Start()
    {
		
		if (Application.systemLanguage == SystemLanguage.Russian)
        {
            //Debug.Log("This system is in Rus. ");
			//infoText.GetComponent<Text>() = "qqq";
			Text_Mission.GetComponent<Text>().text = "Миссия: скинуть все шары с арены";
			infoText.GetComponent<Text>().text = "Для управления наклоняйте устройство и/или свайпите по экрану";
			
			RadioEasyText.GetComponent<Text>().text = "Легко";
			RadioMiddleText.GetComponent<Text>().text = "Норм";
			RadioHardText.GetComponent<Text>().text = "Жесть";
			Button_GOText.GetComponent<Text>().text = "Начать Игру!";
			butReloadText.GetComponent<Text>().text = "Переиграть";
			butReloadWinText.GetComponent<Text>().text = "Переиграть";
			ScoreGOText.GetComponent<Text>().text = "Ваш счет:";
			ScoreWinText.GetComponent<Text>().text = "Ваш счет:";
			ic_redVragTextMax.GetComponent<Text>().text = "макс. 15";
			ic_greenVragTextMax.GetComponent<Text>().text = "макс. 100";
			
			controlText.GetComponent<Text>().text = "Управление:";
			controlAkcelText.GetComponent<Text>().text = "Акселерометр";
			controlSwipeText.GetComponent<Text>().text = "Свайп";
        }
        
    }


}
