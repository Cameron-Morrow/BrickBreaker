using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	
	private Scene scene;	
	
	void Start () {
		scene = SceneManager.GetActiveScene();
	}

	public void LoadLevel(string name){
		SceneManager.LoadScene(name);
	}
	public void CompleteLevel () {
		switch(scene.name){
			case "level_01":
				LoadLevel("level_02");
				break;
			case "level_02":
				LoadLevel("level_03");
				break;
			case "level_03":
				LoadLevel("level_win");
				break;
		}
	}
}
