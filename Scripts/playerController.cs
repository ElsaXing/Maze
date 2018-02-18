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
			z = -1.2f;
		}
		if (Input.GetKeyDown ("s")) {
			z = 1.2f;
		}

		//on phone
		//if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
		//	x = Input.GetTouch (0).deltaPosition.x * speed;
		//}

		move.Set (-x, 0, z);
		rb.velocity = move / Time.deltaTime;

	}
}