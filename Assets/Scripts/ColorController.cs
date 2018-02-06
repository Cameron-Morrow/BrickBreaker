using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour {

	private Text text;
	
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	private float time = 0.0f;
	public float interpolationPeriod = 0.21f;
 
	void Update () {
		time += Time.deltaTime;
 
		if (time >= interpolationPeriod) {
			time = 0.0f;

			if(text.color == Color.green){
				text.color = new Color(0.86275f, 1.0f, 0.0f);
			}else{
				text.color = Color.green;
			}
		}
	}
}
