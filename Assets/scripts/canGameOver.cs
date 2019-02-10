using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canGameOver : MonoBehaviour
{
    // Перезагрузка игры
	
	public void ReloadGame () 
	{ 
             Application.LoadLevel(0); 
			 
	}
	
}
