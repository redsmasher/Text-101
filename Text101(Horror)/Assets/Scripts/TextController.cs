using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour 
{
	public Text text;

	void Start ()
	{
		text.text = "Hello world";
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			text.text = "Space key pressed";
		}
	}
}
