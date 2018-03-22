using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PacManController : MonoBehaviour {
	NavMeshAgent agent;

	public int livesCount;
	private int initLives = 3;

	public AudioSource chomp;

	public Transform PacmanSpawnLoc;
	public GameObject PacmanPrefab;

	void Start() {
		agent = GetComponent<NavMeshAgent>();
		livesCount = initLives;

	}


	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
				agent.destination = hit.point;
			}
		}
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag.Equals ("dot")) {

			Destroy (other.gameObject);
			chomp.Play ();
			GameManager.nomNom ();
		}

		if (other.tag.Equals ("Ghost") && livesCount > 0) {
			livesCount--;
			Destroy (gameObject);
			Debug.Log("You died.");

			}

		}
	}





