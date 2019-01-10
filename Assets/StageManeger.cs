using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StageManeger : MonoBehaviour {

    public List<GameObject> field = new List<GameObject>();
    
	// Use this for initialization
	void Start () {
        field = GameObject.FindGameObjectsWithTag("Feild").ToList();

        for(int i = 0 ; i < 3 ; i++)
        {
            int rad = Random.Range(0,99);
            Debug.Log(field[rad]);
            treecreate tc = field[rad].GetComponent<treecreate>();
            tc.Treecreate();
        }
        for (int i = 0; i < 3; i++)
        {
            int rad = Random.Range(0, 99);
            Debug.Log(field[rad]);
            treecreate sc = field[rad].GetComponent<treecreate>();
            sc.Stonecreate();
        }


    }
	
	// Update is called once per frame
	void Update () {
		

	}
}
