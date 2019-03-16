using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static GameObject timer;
	public static GameObject Player;
	public static GameObject[] VragList;
	public static GameObject Vrag;
	public static GameObject VragClone;
	public static float timeLeft = 0f;
	public static GameObject canSetting;
	public static GameObject CanStart;
	public static GameObject DualTouchControls;
	
}

public class Globals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
		Global.timer = GameObject.Find("timer");
		Global.Player = GameObject.Find("Player");
		Global.Vrag = GameObject.Find("vrag2");
		//Global.VragList = GameObject.FindGameObjectsWithTag("vragTag");
		Global.canSetting = GameObject.Find("canSetting");
		Global.CanStart = GameObject.Find("CanStart");
		Global.DualTouchControls = GameObject.Find("DualTouchControls");
		
		//Debug.Log ( Global.VragList );
		
        
    }
	
	void Update()
	{
		
		Global.VragList = GameObject.FindGameObjectsWithTag("vragTag");
		
	}

}
