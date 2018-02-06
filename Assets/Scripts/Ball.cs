using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	
	private AudioSource audioSource;
	public AudioClip[] bounce;
	public Rigidbody2D rb;
	private float MousePositionInBlocks;
	public bool thrown;
	
	void Awake () {
		audioSource = GetComponent<AudioSource>();
		rb = GetComponent<Rigidbody2D>();
	}

	void Start () {
		
	}
	
	void Update () {
		if(!thrown){
			MousePositionInBlocks = Input.mousePosition.x / Screen.width * 18;
			this.transform.position = new Vector3(Mathf.Clamp(MousePositionInBlocks-9, -8f, 8f), -2.9f, this.transform.position.z);
			if (Input.GetMouseButtonDown(0)){
				rb.AddForce(transform.up * 400);
				thrown = true;
			}
		}
	}
	
	void OnCollisionEnter2D (Collision2D coll) {
		Vector2 tweak = new Vector2 (Random.Range(-0.2f, 0.2f), Random.Range(0.0f, 0.0f));
		if(thrown == true){
			int bounceNum = Random.Range(0, 4);
			audioSource.clip = bounce[bounceNum];
			audioSource.Play();
		}
		rb.velocity += tweak;
	}
}
