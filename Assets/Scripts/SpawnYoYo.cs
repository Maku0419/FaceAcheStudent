using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnYoYo : MonoBehaviour {

	public GameObject yoyo;
	public float MovementForce = 100f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject clone = Instantiate (yoyo, transform.position, Quaternion.identity) as GameObject;
			rb = clone.GetComponent<Rigidbody> ();
			rb.AddForce (MovementForce, 0, 0, ForceMode.Impulse);
		}
	}
}
