using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinButton : MonoBehaviour {
	
	private LevelManager levelManager;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnMouseDown(){
		if (Input.GetMouseButtonDown(0)) {
			levelManager.LoadLevel("level_win");
		}
	}
}
