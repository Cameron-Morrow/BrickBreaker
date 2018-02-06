using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePowerUp : MonoBehaviour {
	
	private PlayerController player;

	void Start () {
		player = GameObject.FindObjectOfType<PlayerController>();
	}
	
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		player.ChangePaddleSize(3);
	}
}
