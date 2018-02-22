using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changeScene : MonoBehaviour {
	public Camera mainCam;
	public Camera endCam;
	public Animator anim;

	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);

		mainCam.enabled = false;
		endCam.enabled = true;

		GameObject.Find ("block").SetActive (false);
		GameObject.Find ("frontBlock").SetActive (false);


		anim.SetBool ("endLevel", true);

	}
}
