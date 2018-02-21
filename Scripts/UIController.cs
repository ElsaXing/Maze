using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour {
	public Button nextLevel;

	void Start() {
		Button btn = nextLevel.GetComponent<Button> ();
		btn.onClick.AddListener (NextLevelOnClick);
	}

	void NextLevelOnClick() {
		Debug.Log ("before");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log ("after");
	}

}
