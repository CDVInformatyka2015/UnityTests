using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderNavigationChangeDestination : MonoBehaviour {

    public NavMeshScript find;
    private int i = 0;
    
	void Start () {
	}
	
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        find.find = !find.find;
        i=0;
    }

    void OnTriggerStay(){
        i++;
        if (i>50){
            find.find = !find.find;
            i=0;
        }
    }

    void OnTriggerExit(){
        i=0;
    }
}
