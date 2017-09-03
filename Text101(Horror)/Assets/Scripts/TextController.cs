using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour 
{
	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	void Start ()
	{
		myState = States.cell;
	}

	void Update ()
	{
		print (myState);
		if (myState == States.cell) 
		{
			state_cell ();
		}
		else if(myState == States.sheets_0)
		{
			state_sheets0 ();
		}
	}

	void state_cell()
	{
		text.text = "You are in a prison cell and you want to escape, use everything you can find to escape!"+
		" There are some dirty sheets in the bed, a mirror in the wall and some filthy tools on the floor\n\n"+
		"Press S to view Sheets, M to view Mirror, T to view tools";

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			myState = States.sheets_0;
		}
	}

	void state_sheets0()
	{
		text.text = "I'm tired of sleeping on these things!\n\n"+
					"Press R to return";

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			myState = States.cell;
		}
	}
}
