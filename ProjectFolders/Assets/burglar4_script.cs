﻿using UnityEngine;
using System.Collections;

public class burglar4_script : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI (){
		
		GUILayout.BeginArea (new Rect (Screen.width / 2-50, Screen.height / 2 - 100, Screen.width - 10, 200));
		
		GUILayout.Label ("BURGLAR 4", GUILayout.Width (200)); 
		
		GUILayout.EndArea ();
		
		GUILayout.BeginArea(new Rect(Screen.width / 4, Screen.height / 2 , Screen.width /2, 200));
		// Load the main scene
		// The scene needs to be added into build setting to be loaded!
		
		
		if (GUILayout.Button("Back"))
		{
			Application.LoadLevel("meet_the_burglars_scene");
		}
		
		
		GUILayout.EndArea();
	}
}
