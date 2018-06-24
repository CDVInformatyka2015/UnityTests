using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshScript : MonoBehaviour {

    NavMeshAgent agent;
    public Transform target;
    public Transform target2;
    public bool find = true;

	// Use this for initialization
	void Start () {
        agent = transform.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (find)
            agent.SetDestination(target.position);
        else
            agent.SetDestination(target2.position);
	}
}
