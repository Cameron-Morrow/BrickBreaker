using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoKids : MonoBehaviour {
	
	private LevelManager levelManager;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.childCount <= 0){
			levelManager.CompleteLevel();
		}
	}
}
