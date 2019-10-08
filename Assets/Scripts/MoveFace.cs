using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFace : MonoBehaviour {

	Rigidbody rb;
	public float MovementForce = 100f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey(KeyCode.LeftArrow)) {
				PushLeft ();
			}
			if (Input.GetKey(KeyCode.RightArrow)) {
				PushRight ();
			}
			if (Input.GetKey(KeyCode.UpArrow)) {
				PushUp ();
			}
			if (Input.GetKey(KeyCode.DownArrow)) {
				PushDown ();
			}
	}

	void PushLeft(){
		rb.AddForce (0, 0, MovementForce, ForceMode.Impulse);
	}
	void PushRight(){
		rb.AddForce (0, 0, -MovementForce, ForceMode.Impulse);
	}
	void PushUp(){
		rb.AddForce (MovementForce, 0, 0, ForceMode.Impulse);
	}
	void PushDown(){
		rb.AddForce (-MovementForce, 0, 0, ForceMode.Impulse);
	}
}
