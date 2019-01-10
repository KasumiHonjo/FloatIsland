using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmcreate : MonoBehaviour {

    public GameObject farmPrefab;

    private GameObject fagm;

    // Use this for initialization
    void Start () {
        fagm = GameObject.Find("GameManeger");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Getfarmcreate()
    {
        Vector3 posi = this.transform.position;
        posi.y = +0.5f;
        GameObject instance = Instantiate(farmPrefab, posi, farmPrefab.transform.rotation);
        instance.transform.SetParent(transform);

        GameManager gm = fagm.GetComponent<GameManager>();
        gm.FarmAction();
    }
}
