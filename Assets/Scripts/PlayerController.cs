using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private LevelManager levelManager;
	private float MousePositionInBlocks;
	private Ball ball;
	private int paddleSize = 2;
	private float clampSize = 8;
	
	public ExtraLife[] extraLife;
	public int lives = 3;
	public bool testMode = false;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void Update () {
		if(!testMode){
			MoveWithMouse();
		}else{
			ball = GameObject.FindObjectOfType<Ball>();
			this.transform.position = new Vector3(Mathf.Clamp(ball.rb.transform.position.x, -clampSize, clampSize), this.transform.position.y, -5.0f);
		}
	}
	
	void MoveWithMouse () {
		MousePositionInBlocks = Input.mousePosition.x / Screen.width * 18;
		this.transform.position = new Vector3(Mathf.Clamp(MousePositionInBlocks-9, -clampSize, clampSize), this.transform.position.y, -5.0f);
	}
	
	public int LoseLives () {
		if(lives == 3){
			extraLife[2].killSelf();
		}
		if(lives == 2){
			extraLife[1].killSelf();
		}
		if(lives == 1){
			extraLife[0].killSelf();
		}
		lives--;
		return lives;
	}
	
	public void ChangePaddleSize(int size){
		paddleSize = size;
		switch(paddleSize){
			case 1:
				clampSize = 9;
				this.GetComponent<Transform>().localScale = new Vector3 (0.5f, this.GetComponent<Transform>().localScale.y, this.GetComponent<Transform>().localScale.z);
				break;
			case 2:
				clampSize = 8;
				this.GetComponent<Transform>().localScale = new Vector3 (1.0f, this.GetComponent<Transform>().localScale.y, this.GetComponent<Transform>().localScale.z);
				break;
			case 3:
				clampSize = 7;
				this.GetComponent<Transform>().localScale = new Vector3 (3.0f, this.GetComponent<Transform>().localScale.y, this.GetComponent<Transform>().localScale.z);
				break;
		}
	}
}
