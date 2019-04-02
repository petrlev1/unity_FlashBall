using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
	
	 Toggle _Toggle = null;
 
    void Awake()
    {
        _Toggle = GetComponent<Toggle>();
        LoadValue();
    }
 
    void LoadValue()
    {
        Debug.Log("Loading... " + _Toggle.isOn);
    }
 
    public void UpdateValue(bool value)
    {
        Debug.Log("Saving... " + value);
    }
	
}
