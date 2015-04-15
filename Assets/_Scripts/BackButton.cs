using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{
	void OnGUI()
	{
		GUI.Box (new Rect (900, 900, 50, 50), "");
		if (GUI.Button (new Rect (10, 10, 85, 40), "")) 
		{
			Application.LoadLevel ("_MainMenuScene");
		}
	}
}
