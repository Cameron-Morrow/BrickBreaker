using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	private LevelManager levelManager;
	private float MousePositionInBlocks;
	public LoseLife[] lifeSprites;
	public int lifes = 3;
	private Ball ball;
	public bool testMode = false;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		//lifeSprites = GameObject.FindObjectsOfType<LoseLife>() as LoseLife[];
	}
	
	void Update () {
		if(!testMode){
			if (Input.GetKey(KeyCode.A)) {
				levelManager.LoadLevel("game_over");
			}
			if (Input.GetKey(KeyCode.D)) {
				levelManager.LoadLevel("level_win");
			}
			MoveWithMouse();
		}else{
			ball = GameObject.FindObjectOfType<Ball>();
			this.transform.position = new Vector3(Mathf.Clamp(ball.rb.transform.position.x, -8f, 8f), this.transform.position.y, -5.0f);
		}
	}
	
	void MoveWithMouse () {
		MousePositionInBlocks = Input.mousePosition.x / Screen.width * 18;
		this.transform.position = new Vector3(Mathf.Clamp(MousePositionInBlocks-9, -8f, 8f), this.transform.position.y, -5.0f);
	}
	
	public int Lives () {
		if(lifes == 3){
			lifeSprites[2].killSelf();
		}
		if(lifes == 2){
			lifeSprites[1].killSelf();
		}
		if(lifes == 1){
			lifeSprites[0].killSelf();
		}
		lifes--;
		return lifes;
	}
}
