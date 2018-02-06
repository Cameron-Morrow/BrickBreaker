using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour {
	
	public AudioClip crack;
	public AudioClip poof;
	public Sprite[] hitSprites;
	public Sprite[] dieSprites;
	
	private AudioSource audioSource;
	private int timesHit = 0;
	
	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void Start () {
	}
	
	void Update () {
	}
	
	IEnumerator OnCollisionEnter2D (Collision2D trigger) {
		
		timesHit++;
		
		if(timesHit >= hitSprites.Length){
			yield return Explode();
		}else{
			PlayAudio(crack);
			LoadSprites();
		}
		
	}
	
	void LoadSprites () {
		
		int spriteIndex = timesHit;
		
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		
	}
	
	IEnumerator Explode () {
		
		PlayAudio(poof);
		
		for(int i = 0; i < 8; i++){
			
			this.GetComponent<SpriteRenderer>().sprite = dieSprites[i];
			
			yield return new WaitForSeconds(0.05f);
		}
		
		Destroy(gameObject);
		
	}
	
	private void PlayAudio (AudioClip sound) {
		audioSource.clip = sound;
		audioSource.Play();
	}
}
