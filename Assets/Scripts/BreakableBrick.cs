using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour {
	public AudioClip crack;
	public AudioClip poof;
	private int timesHit = 0;
	public Sprite[] hitSprites;
	public Sprite[] dieSprites;
	private AudioSource audioSource;
	
	void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	IEnumerator OnCollisionEnter2D(Collision2D trigger){
		timesHit++;
		if(timesHit >= hitSprites.Length){
			yield return Explode();
		}else{
			audioSource.clip = crack;
			audioSource.Play();
			LoadSprites();
		}
	}
	void LoadSprites () {
		int spriteIndex = timesHit;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
	IEnumerator Explode() {
		audioSource.clip = poof;
		audioSource.Play();
		for(int i = 0; i < 8; i++){
			this.GetComponent<SpriteRenderer>().sprite = dieSprites[i];
			
			yield return new WaitForSeconds(0.05f);
		}
		Destroy(gameObject);
	}
}
