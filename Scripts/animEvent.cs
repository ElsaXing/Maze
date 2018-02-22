using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animEvent : MonoBehaviour {
	public GameObject Next;
	public GameObject Complete;
	public Canvas canvas;


	public void addUI() {
		if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene ().buildIndex + 1) {
			AddNextBtn ();
		} else {
			AddCompleteBtn ();
		}
			
	}

	void NextLevelOnClick() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	void AddNextBtn ()  {
		GameObject next = (GameObject)Instantiate(Next); 
		next.transform.SetParent(canvas.transform, false);
		Button btn = next.GetComponent<Button> ();
		btn.onClick.AddListener (NextLevelOnClick);
	}

	void AddCompleteBtn () {
		GameObject complete = (GameObject)Instantiate(Complete); 
		complete.transform.SetParent(canvas.transform, false);
	}

}
