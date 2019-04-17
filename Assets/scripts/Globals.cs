using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
	public static GameObject mCamera;
    public static GameObject timer;
	public static GameObject Player;
	public static GameObject[] VragList;
	public static GameObject[] VragListClone;
	public static GameObject Vrag;
	public static GameObject VragClone;
	public static float vragSpeed = 5f;
	public static float timeLeft = 0f;
	public static GameObject canSetting;
	public static GameObject canMainInt;
	public static GameObject CanStart;
	public static GameObject canWin;
	public static GameObject canGameOver;
	public static GameObject DualTouchControls;
	public static GameObject sfx;
	//sfx AudioSource;
	
}

public class Globals : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
		
		Global.mCamera = GameObject.Find("mCamera");
		Global.timer = GameObject.Find("timer");
		Global.Player = GameObject.Find("Player");
		//Global.VragList = GameObject.FindGameObjectsWithTag("vragTag");
		Global.canSetting = GameObject.Find("canSetting");
		Global.canMainInt = GameObject.Find("canMainInt");
		Global.CanStart = GameObject.Find("CanStart");
		Global.canWin = GameObject.Find("canWin");
		Global.canWin.SetActive(false);
		Global.canGameOver = GameObject.Find("canGameOver");
		Global.canGameOver.SetActive(false);
		Global.DualTouchControls = GameObject.Find("DualTouchControls");
		Global.sfx = GameObject.Find("sfx");
		
		//Global.canGameOver.SetActive(false);
		//Debug.Log ( Global.VragList );
        
    }
	
	void Start()
	{
		
	//Global.sfx.GetComponent<sfx>().audio_magic1();
		//Global.canWin.SetActive(true);
		
	//Появление врага каждые n сек
    InvokeRepeating("newVrag", 0, 8f);	
		
	}

	
	void Update()
	{
		
		Global.VragList = GameObject.FindGameObjectsWithTag("vragTag");
		Global.VragListClone = GameObject.FindGameObjectsWithTag("vragTagClone");
		Global.Vrag = GameObject.Find("vrag2");
		Global.VragClone = GameObject.Find("vrag2(Clone)");
		//Global.sfx = GameObject.Find("sfx");
		//Debug.Log ( Global.VragClone );
		//AudioSource.victory.Play();
		
		//Вызываем функцию выигрыша
		Global.canWin.GetComponent<canWin>().canWinFunc();
		
		//Вызываем функцию проигрыша
		//Global.canGameOver.GetComponent<canGameOver>().GameOverFunc();
		//Global.mCamera.GetComponent<functions>().GameOverFunc();
		//GetComponent<functions>().GameOverFunc();
		Global.canGameOver.GetComponent<canGameOver>().GameOverFunc();
		
		//Debug.Log ( "test" );
		
	}
	
	//Метод появления врага
	void newVrag()
	{
		GameObject vragNew = Instantiate(Global.Vrag, new Vector3 (0, 2, 0), transform.rotation);
		vragNew.gameObject.name = "vrag2";
	}

}
