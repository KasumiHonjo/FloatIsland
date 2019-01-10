using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoplecreate : MonoBehaviour {

    public GameObject people;

    public GameObject ppcpos;

    public GameObject PPC;

    public float createtime = 5;

    private float timer;

    private GameObject ppla;

    // Use this for initialization
    void Start()
    {
        ppla = GameObject.Find("GameManeger");
        PPC = GameObject.Find("UTCPrefab");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        GameManager gm = ppla.GetComponent<GameManager>();

        if (gm.people < gm.PeopleMax)
        {
            if (timer > createtime)
            {
                GameObject peinstans = Instantiate(people) as GameObject;
                peinstans.transform.position = ppcpos.transform.position;
                
                gm.PeopleAction();
                timer = 0;
            }
        }
    }
}
