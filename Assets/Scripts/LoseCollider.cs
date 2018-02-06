using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
	
	private LevelManager levelManager;
	private PlayerController player;
	private Ball ball;
	
	void Start () {
		
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		player = GameObject.FindObjectOfType<PlayerController>();
		ball = GameObject.FindObjectOfType<Ball>();
		
	}
	
	void OnTriggerEnter2D(Collider2D trigger){
		
		int lives = player.LoseLives();
		
		if(lives <= 0){
			levelManager.LoadLevel("game_over");
		}
		
		ball.rb.velocity = Vector3.zero;
		
		ball.thrown = false;
	}
}
