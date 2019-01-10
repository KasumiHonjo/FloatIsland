using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class peoplemove : MonoBehaviour {

    public GameObject[] Target;
    
    NavMeshAgent mynav;

	// Use this for initialization
	void Start () {

        Target = GameObject.FindGameObjectsWithTag("Tree");

        mynav = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
		
        if(mynav.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            int rads = Random.Range(0, Target.Length);
            mynav.SetDestination(Target[rads].transform.position);
            Debug.Log(Target[rads].transform.position);
        }
	}
}
