using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redVragText : MonoBehaviour
{
    Text text;
	
    void Start()
    {
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		text = GetComponent<Text>();
		text.text = Global.VragList.Length.ToString();
        
    }
}
