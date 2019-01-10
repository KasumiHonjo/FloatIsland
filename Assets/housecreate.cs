using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class housecreate : MonoBehaviour {

    public GameObject house1Prefab;

    public GameObject house2Prefab;

    private GameObject hogm;

    //public GameObject block;

	// Use this for initialization
	void Start () {
        hogm = GameObject.Find("GameManeger");
    }
	
	// Update is called once per frame
	void Update() { 
        
    }

    public void Gethouse1create()
    {
        Vector3 posi = this.transform.position;
        posi.y =+ 0.5f;
        GameObject instance =Instantiate(house1Prefab, posi, house1Prefab.transform.rotation);
        instance.transform.SetParent(transform);

        GameManager gm = hogm.GetComponent<GameManager>();
        gm.House1Action();
        
    }

    public void Gethouse2create()
    {
        Vector3 posi = this.transform.position;
        posi.y = +0.5f;
        GameObject instance = Instantiate(house2Prefab, posi, house2Prefab.transform.rotation);
        instance.transform.SetParent(transform);

        GameManager gm = hogm.GetComponent<GameManager>();
        gm.House2Action();
    }

    /*[ContextMenu("create")]
    public void create()
    {
        for (int i= 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject instance = Instantiate(block, new Vector3(j,0,i), block.transform.rotation);
                instance.name = i.ToString() + j.ToString();
            }
        }
    }*/
}
