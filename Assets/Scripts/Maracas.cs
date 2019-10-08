using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maracas : MonoBehaviour {

	public AudioClip touchSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			if (touchSound) {
				AudioSource.PlayClipAtPoint (touchSound, transform.position);
			}
		}
	}
}
