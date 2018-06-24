using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderNavigationChangeDestination : MonoBehaviour {

    NavMeshScript find;
	// Use this for initialization
	void Start () {
        find = gameObject.GetComponent<NavMeshScript>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        find.find = !find.find;
    }
}
