using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public int speed;
	public Rigidbody rb;

	private Vector3 move;
	//public GameObject[] walls;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		move.Set (0, 0, 0);
		rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		transform.rotation = Quaternion.Euler (90, 0, 0);

		//on pc
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		var z = 0f;

		if (Input.GetKeyDown ("w")) {
			z = -1.25f;
		}
		if (Input.GetKeyDown ("s")) {
			z = 1.25f;
		}

		//on phone
		Rect topLeft = new Rect(0, 0, Screen.width / 2, Screen.height / 2);
		Rect bottomLeft = new Rect(0, Screen.height / 2, Screen.width / 2, Screen.height / 2);
		Rect right = new Rect(Screen.width / 2, 0, Screen.width / 2, Screen.height);

		if (Input.touchCount > 0) {
			var touchPos = Input.GetTouch(0).position;
			if (topLeft.Contains(touchPos) && Input.GetTouch (0).phase == TouchPhase.Began)
			{
				z = 1.2f;
			}
			if (bottomLeft.Contains(touchPos) && Input.GetTouch (0).phase == TouchPhase.Began)
			{
				z = -1.2f;
			}
			if (right.Contains(touchPos) && Input.GetTouch (0).phase == TouchPhase.Moved)
			{
				x = Input.GetTouch (0).deltaPosition.x * speed / 100;
			} 

		}

		move.Set (-x, 0, z);
		rb.velocity = move / Time.deltaTime;

	}
}