using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGround : MonoBehaviour {

	public float rotateSpeed = 1f;
	private float rotationDirectionZ = 0;
	private float rotationDirectionX = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate(Time.deltaTime * rotationDirectionX, 0, Time.deltaTime * rotationDirectionZ);
		//transform.Rotate(0, 0, rotationZ);
		float h = Input.GetAxisRaw ("Horizontal");
		if (h > 0) {
			rotationDirectionZ = -rotateSpeed;
		} else if (h < 0) {
			rotationDirectionZ = rotateSpeed;
		} else {
			rotationDirectionZ = 0;
		}
		float v = Input.GetAxisRaw ("Vertical");
		if (v > 0) {
			rotationDirectionX = rotateSpeed;
		} else if (v < 0) {
			rotationDirectionX = -rotateSpeed;
		} else {
			rotationDirectionX = 0;
		}

	}
}
