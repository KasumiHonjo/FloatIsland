using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour {

    private GameObject GM;

    public GameObject can;
    private int bname;

    // Use this for initialization
    void Start()
    {
        GM = GameObject.Find("GameManeger");
        can = GameObject.Find("Canvas");

    }

    // Update is called once per frame
    void Update()
    {
        bname = can.GetComponent<selectButton>().buttonname;
    }

    public void FMsub()
    {
        GameManager gm = GM.GetComponent<GameManager>();
        gm.FMsubAction();
    }

    public void FMsum()
    {
        GameManager gm = GM.GetComponent<GameManager>();
        gm.FMsumAction();
    }
}
