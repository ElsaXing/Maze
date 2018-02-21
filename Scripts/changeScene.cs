using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {
	public Camera mainCam;
	public Camera endCam;
	public Animator anim;

	private GameObject block;
	private GameObject frontBlock;

	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);

		mainCam.enabled = false;
		endCam.enabled = true;

		block = GameObject.Find ("block");
		frontBlock = GameObject.Find ("FrontBlock");

		block.SetActive (false);
		frontBlock.SetActive (false);


		anim.SetBool ("endLevel", true);

		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
