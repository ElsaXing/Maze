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

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		transform.rotation = Quaternion.Euler (0, 0, 0);

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		var z = 0f;

		if (Input.GetKeyDown ("w")) {
			z = -1.3f;
		}
		if (Input.GetKeyDown ("s")) {
			z = 1.3f;
		}

		move.Set (-x, 0, z);
		rb.velocity = move / Time.deltaTime;

	}
}