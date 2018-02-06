using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {
	
	private float MousePositionInBlocks;
	public Rigidbody2D rb;
	public bool thrown;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		thrown = false;
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
}
