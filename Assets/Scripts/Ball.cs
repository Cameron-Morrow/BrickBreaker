using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	
	private AudioSource audioSource;
	public AudioClip[] bounce;
	private Launcher ballLauncher;
	public Rigidbody2D rb;
	
	
	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
		ballLauncher = GameObject.FindObjectOfType<Launcher>();
		rb = GetComponent<Rigidbody2D>();
	}

	void Start () {
		
	}
	
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll){
		Vector2 tweak = new Vector2 (Random.Range(-0.2f, 0.2f), Random.Range(0.0f, 0.0f));
		if(ballLauncher.thrown == true){
			int bounceNum = Random.Range(0, 4);
			audioSource.clip = bounce[bounceNum];
			audioSource.Play();
		}
		rb.velocity += tweak;
	}
}
