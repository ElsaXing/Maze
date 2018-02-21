using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
	public GameObject player;
	public Material distance_wall;
	public Material original_wall;
	public Camera endCam;

	private Vector3 offset;
	private float distance;
	private GameObject[] distanceWalls;
	private GameObject[] walls;
	private GameObject[] frontBlocks;
	private float cameraLeftEdge = -1.5f;
	private float cameraRightEdge = 1.5f;

	// Use this for initialization
	void Start () {
		endCam.enabled = false;

		walls = GameObject.FindGameObjectsWithTag("wall");
		frontBlocks = GameObject.FindGameObjectsWithTag ("frontBlock");

		offset = transform.position - player.transform.position;
		foreach (GameObject wall in walls) {
			Rigidbody rb = wall.GetComponent<Rigidbody> ();
			rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
		}
	}
		

	void LateUpdate () {
		Vector3 cameraPosition = (player.transform.position + offset);
		cameraPosition.x = Mathf.Clamp (cameraPosition.x, cameraLeftEdge, cameraRightEdge);
		transform.position = cameraPosition;

		foreach (GameObject wall in walls) {
			distance = transform.position.z - wall.transform.position.z;
			Material targetMaterial = original_wall;
			if (distance > 3) {
				targetMaterial = distance_wall;
			}
			wall.GetComponent<Renderer> ().material = targetMaterial;
		}

		foreach (GameObject frontBlock in frontBlocks) {
			distance = transform.position.z - frontBlock.transform.position.z;
			if (distance > 2) {
				frontBlock.active = false;
			} else {
				frontBlock.active = true;
			}
		}
	}
}
