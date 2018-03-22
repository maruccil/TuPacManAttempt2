using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanSpawner : MonoBehaviour {


	public static Transform TupacSpawnLoc;
	public static GameObject tupacPrefab;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void spawnTupac ()
	{
		var tupac = (GameObject)Instantiate (tupacPrefab,
			TupacSpawnLoc.position, TupacSpawnLoc.rotation);
		Debug.Log ("You've been respawned! ");


	}
}