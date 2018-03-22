using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	GameObject playerObj;
	Vector3 CameraOffset;
	// Use this for initialization
	void Start () {

		playerObj = GameObject.Find("PacMan");
		CameraOffset = new Vector3 (0, 1, -3);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = playerObj.transform.position + CameraOffset;
		
	}
}
