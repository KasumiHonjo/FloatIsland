using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treecreate : MonoBehaviour {

    public GameObject treePrefab;

    public GameObject stonePrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Treecreate()
    {
        Debug.Log("in");
        Vector3 tpos = this.transform.position;
        tpos.y = +0.5f;
        GameObject tree = Instantiate(treePrefab, tpos, treePrefab.transform.rotation);
    }

    public void Stonecreate()
    {
        Vector3 spos = this.transform.position;
        spos.y = +0.5f;
        GameObject stone = Instantiate(stonePrefab, spos, stonePrefab.transform.rotation);

    }
}
