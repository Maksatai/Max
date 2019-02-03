using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour {


    [SerializeField]
    NavMeshAgent navmesh;

    [SerializeField]
    Transform transform;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        navmesh.SetDestination(transform.position);
    }
}
