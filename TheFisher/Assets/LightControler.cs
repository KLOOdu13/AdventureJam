using UnityEngine;
using System.Collections;

public class LightControler : MonoBehaviour 
{

	private Light onOff;
	private bool isOn;
	
	void Start () 
	{
		onOff = GetComponent <Light>();
		isOn = true;
		
		Screen.lockCursor = isOn; // Lock the mouse's cursor at the middle of the screen
		Cursor.visible = false; // It means what is written.
	}

	void LateUpdate () 
	{
		if (isOn)
		{
			onOff.enabled = true; // Light On

			if (Input.GetMouseButtonDown(0)) // On Left click turn the light Off
				isOn = false;

		}
		else
		{
			onOff.enabled = false; // Light Off

			if (Input.GetMouseButtonDown(0)) // On Left click turn the light On
				isOn = true;
		}

	}
}
