using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetector : MonoBehaviour {
	
	private LevelManager levelManager;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void Update () {
		if(transform.childCount <= 0){
			levelManager.CompleteLevel();
		}
	}
}
