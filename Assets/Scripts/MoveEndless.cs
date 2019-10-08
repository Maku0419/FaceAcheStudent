using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEndless : MonoBehaviour {

	Rigidbody rb;
	public float MovementForce = 100f;
	public AudioClip pickUpSound;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//if ((Mathf.Abs(rb.velocity.x) < 0.5f) && (Mathf.Abs(rb.velocity.z) < 0.5f) && (Mathf.Abs(rb.velocity.y) < 0.5f)) {
		//rb.velocity = new Vector3 (0, 0, 0);
		//transform.eulerAngles = Vector3.zero;
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
		//}
		rb.AddForce (0, 0, MovementForce, ForceMode.Impulse);
	}

	void PushUp(){
		rb.AddForce (0, 0, MovementForce, ForceMode.Impulse);
	}
	void PushDown(){
		rb.AddForce (0, 0, -MovementForce, ForceMode.Impulse);
	}
	void PushLeft(){
		rb.AddForce (-MovementForce, 0, 0, ForceMode.Impulse);
	}
	void PushRight(){
		rb.AddForce (MovementForce, 0, 0, ForceMode.Impulse);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Collectable") {
			if (pickUpSound) {
				AudioSource.PlayClipAtPoint (pickUpSound, transform.position);
			}
			Destroy(other.gameObject);
		}
	}
}
