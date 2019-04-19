using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redVragText : MonoBehaviour
{
    Text text;
	private GameObject[] VragiList;
	
    void Start()
    {
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		VragiList = GameObject.FindGameObjectsWithTag("vragTag");
		
		text = GetComponent<Text>();
		text.text = VragiList.Length.ToString();
        
    }
}
