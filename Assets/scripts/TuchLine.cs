using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.CrossPlatformInput;

public class TuchLine : MonoBehaviour
{
    
	public GameObject player;
	Vector3 touchPosition;
	
	private Vector3 LinePos1;
	private Vector3 LinePos2;
	
	Color c1 = Color.green;
    Color c2 = Color.red;
	//Color lerpedColor;
	
	//private float ChargeLevel = 0f;
    //private float ChargeSpeed = 0.9f;
	
	//public Layer layerMask;
	
	public LayerMask hitLayers;
	
    void Start()
    {
		
        
    }

    // Update is called once per frame
    void Update()
    {
		
		//lerpedColor = Color.Lerp(Color.green, Color.red, Mathf.Min(Time.time, 1));
		
		touchPosition = Input.mousePosition;
		//touchPosition = CrossPlatformInputManager;
		
		Ray castPoint = Camera.main.ScreenPointToRay(touchPosition);
        RaycastHit hit;
		//Physics.Raycast(castPoint, out hit, 100);
		Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers);
		//Debug.DrawLine(hit.point, player.transform.position, Color.red);
		
		LinePos1 = hit.point;
		LinePos2 = player.transform.position;
		
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		
		if ( Input.GetMouseButton(0) ) {
		GetComponent<LineRenderer>().enabled = true;
		lineRenderer.SetPosition(0, LinePos1);
		lineRenderer.SetPosition(1, LinePos2);
		//lineRenderer.SetColors(c1, c1);
		} else {
			GetComponent<LineRenderer>().enabled = false;
		}
		
		
		
		
		/* // Считаем время удержания кнопки мыши
		if (Input.GetMouseButton(0))
        {
            ChargeLevel += Time.deltaTime * ChargeSpeed;
        }
		//Скидываем значение удержания
        if (Input.GetMouseButtonUp(0))
        {
            ChargeLevel = 0f;
        } */
		
		//Меняем цвет линии
		//gameObject.GetComponent<Renderer> ().material.color = Color.Lerp(c1, c2, ChargeLevel);
		
		
		
		//Debug.Log(ChargeLevel);
		
        
    }
}
