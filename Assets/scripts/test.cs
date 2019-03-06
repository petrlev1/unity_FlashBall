using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
	
	 Toggle m_Toggle;
    public Text m_Text;

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, and output the state
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });

        //Initialize the Text to say whether the Toggle is in a positive or negative state
		Debug.Log ( "Toggle is : " + m_Toggle.isOn );
    }
	
	void Update()
    {
		
		//Debug.Log ( "Toggle is : " + m_Toggle.isOn );
		
		//if ( m_Toggle.isOn == true ) { Debug.Log ("YES"); }
		
	}

    //Output the new state of the Toggle into Text when the user uses the Toggle
    void ToggleValueChanged(Toggle change)
    {
		//Debug.Log ( "Toggle is : " + m_Toggle.isOn );
    }
	
}
