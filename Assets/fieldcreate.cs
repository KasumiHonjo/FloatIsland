using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldcreate : MonoBehaviour {

    public GameObject block;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [ContextMenu("create")]
    public void create()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject instance = Instantiate(block, new Vector3(j, 0, i), block.transform.rotation);
                instance.name = "field"+j.ToString() + i.ToString();
            }
        }
    }
}
