using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical")<0) {
			this.GetComponent<Rigidbody> ().AddForce (10f, 0, 0);
		}
		if (Input.GetAxis("Vertical")>0) {
			this.GetComponent<Rigidbody> ().AddForce (-10f, 0, 0);
		}
		if (Input.GetAxis("Horizontal")>0) {
			this.GetComponent<Rigidbody> ().AddForce (0, 0, 10f);
		}
		if (Input.GetAxis("Horizontal")<0) {
			this.GetComponent<Rigidbody> ().AddForce (0, 0, -10f);
		}
		if (transform.position.y < -1.0f) {
			transform.SetPositionAndRotation (new Vector3 (1f, 0.7f, 0f), new Quaternion(0,0,0,0));
		}

	}
}
