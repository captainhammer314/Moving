using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotControl : MonoBehaviour {

	public float xFire;
	public float yFire;

	// Use this for initialization
	void Start () {
		xFire = Input.GetAxis ("xShoot");
		yFire = Input.GetAxis ("yShoot");

		if (xFire > 0.2) {
			xFire = 5;
		}
		if (xFire < -0.2) {
			xFire = -5;
		}

		if (yFire > 0.2) {
			yFire = 5;
		}
		if (yFire < -0.2) {
			yFire = -5;
		}
		GetComponent<Rigidbody> ().velocity = new Vector3 (xFire, yFire, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
