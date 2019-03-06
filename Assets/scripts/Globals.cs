using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static GameObject timer;
	public static GameObject Player;
	public static float timeLeft = 0f;
	public static GameObject canSetting;
	public static GameObject DualTouchControls;
	
}

public class Globals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
		Global.timer = GameObject.Find("timer");
		Global.Player = GameObject.Find("Player");
		Global.canSetting = GameObject.Find("canSetting");
		Global.DualTouchControls = GameObject.Find("DualTouchControls");
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
