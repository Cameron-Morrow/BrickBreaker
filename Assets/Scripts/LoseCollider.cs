using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelManager;
	private PlayerController player;
	private Launcher ball;
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		player = GameObject.FindObjectOfType<PlayerController>();
		ball = GameObject.FindObjectOfType<Launcher>();
	}
	void OnTriggerEnter2D(Collider2D trigger){
		int lives = player.Lives();
		if(lives <= 0){
			levelManager.LoadLevel("game_over");
		}
		ball.rb.velocity = Vector3.zero;
		//ball.rb.angularVelocity = Vector3.zero;
		ball.thrown = false;
	}
}
