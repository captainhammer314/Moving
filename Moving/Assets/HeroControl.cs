using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour {

	public float xVelAdj;
	public float yVelAdj;
	public float xFire;
	public float yFire;

	public float speedModifier = 3;

	public Transform bulletShot;
	public float shotDelay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		xVelAdj = Input.GetAxis ("xMove");
		yVelAdj = Input.GetAxis ("yMove");

		xFire = Input.GetAxis ("xShoot");
		yFire = Input.GetAxis ("yShoot");

		GetComponent<Rigidbody> ().velocity = new Vector3 (speedModifier * xVelAdj, speedModifier * yVelAdj, 0);

		if ((xFire > 0.2 || xFire < -0.2) && (shotDelay == 0)) {
			shotDelay = 1;
			Instantiate (bulletShot, transform.position, bulletShot.rotation);
			StartCoroutine (delayReset ());
		}
		if ((yFire > 0.2 || yFire < -0.2) && (shotDelay == 0)) {
			shotDelay = 1;
			Instantiate (bulletShot, transform.position, bulletShot.rotation);
			StartCoroutine (delayReset ());
		}
	}

	IEnumerator delayReset() {
		yield return new WaitForSeconds (1);
		shotDelay = 0;
	}
}
