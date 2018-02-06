using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePowerUp : MonoBehaviour {
	private PlayerController player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll){
		player.GetComponent<Transform>().localScale = new Vector3 (3.0f, player.GetComponent<Transform>().localScale.y, player.GetComponent<Transform>().localScale.z);
	}
}
