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
			text.text = "You are in a prison cell and you want to escape, use everything you can find to escape!"+
						" There are some dirty sheets in the bed, a mirror in the wall and some filthy tools on the floor\n\n"+
						"Press V to view Sheets, M to view Mirror, T to view tools";
		}
	}
}
