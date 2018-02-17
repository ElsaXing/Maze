using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		SceneManager.LoadScene("sample2");
	}
}
