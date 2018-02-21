using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {
	public Camera mainCam;
	public Camera endCam;
	public Animator anim;

	private GameObject[] blocks;
	private GameObject[] frontBlocks;

	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);

		blocks = GameObject.FindGameObjectsWithTag("block");
		frontBlocks = GameObject.FindGameObjectsWithTag ("frontBlock");

		foreach (GameObject block in blocks) {
			block.active = false;
		}

		foreach (GameObject frontBlock in frontBlocks) {
			frontBlock.active = false;
		}

		mainCam.enabled = false;
		endCam.enabled = true;

		anim.SetBool ("endLevel", true);

		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
