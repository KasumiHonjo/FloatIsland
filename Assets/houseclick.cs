using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseclick : MonoBehaviour {

    public GameObject can;

    private int bname;

    // Use this for initialization
    void Start () {
        can = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        bname = can.GetComponent<selectButton>().buttonname;

        if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject);

                if (bname == 1)
                {
                    hit.collider.gameObject.GetComponent<housecreate>().Gethouse1create();
                }
                else if (bname == 2)
                {
                    hit.collider.gameObject.GetComponent<housecreate>().Gethouse2create();
                }
                else if (bname == 3)
                {
                    hit.collider.gameObject.GetComponent<farmcreate>().Getfarmcreate();
                }
                else {
                    hit.collider.gameObject.GetComponent<housecreate>().Gethouse1create();
                }

            }
        }
    }
}
