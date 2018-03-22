using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Transform ghostSpawn;
	public GameObject ghostPrefab;

	public Transform ghostSpawn2;
	public GameObject ghostPrefab2;

	public Transform ghostSpawn3;
	public GameObject ghostPrefab3;

	public Transform ghostSpawn4;
	public GameObject ghostPrefab4;

	public GameObject dotPrefab;
	 

	public static int dotCount;
	public int initDots = 0;

	private void Start () {
		BeginGame();
	}
	
	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			RestartGame();
		}


/*		List<Cell> cells = new List<Cell>();
	 cellList = List<T>(Int32)
		foreach (GameObject.FindWithTag ("cell").transform in Maze)

	
		Debug.Log (cell); */
	
	
	
	
	
	}

	private void BeginGame () {
		var ghost = (GameObject)Instantiate (ghostPrefab,
			            ghostSpawn.position, ghostSpawn.rotation);
		//Debug.Log("ghost created");

		var ghost2 = (GameObject)Instantiate (ghostPrefab2,
			             ghostSpawn2.position, ghostSpawn2.rotation);
		//Debug.Log("ghost2 created");

		var ghost3 = (GameObject)Instantiate (ghostPrefab3,
			             ghostSpawn3.position, ghostSpawn3.rotation);
		//Debug.Log("ghost3 created");

		var ghost4 = (GameObject)Instantiate (ghostPrefab4,
			             ghostSpawn4.position, ghostSpawn4.rotation);
		//Debug.Log("ghost4 created");



	}


	

	
	

	private void RestartGame () {
		//Destroy(maze.gameObject);
		BeginGame();
	}

	public static void nomNom() {

		dotCount++;
		Debug.Log ("You've eaten" + dotCount + " dots!");

	}




}
