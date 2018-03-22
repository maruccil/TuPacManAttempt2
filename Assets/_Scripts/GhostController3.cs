using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class GhostController3 : MonoBehaviour
{
	public Transform target;
	Vector3 destination;
	UnityEngine.AI.NavMeshAgent agent;


	void Start()
	{ 

		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		destination = agent.destination;

	}

	void Update()
	{

		// Update destination if the target moves one unit
		if (Vector3.Distance(destination, target.position) > 1.0f)
		{
			target = GameObject.FindWithTag("Player").transform;
			agent.destination = target.position;

		}


	}





}