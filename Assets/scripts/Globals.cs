using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    public static GameObject timer;
	public static GameObject Player;
	public static float timeLeft = 0f;
	
}

public class Globals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		
		Global.timer = GameObject.Find("timer");
		Global.Player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
