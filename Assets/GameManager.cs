using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    public GameObject popText;

    public GameObject wcText;

    public GameObject fmText;

    public GameObject ho1Text;

    public GameObject ho2Text;

    public GameObject faText;

    public GameObject Pplm;

    public int PeopleMax = 0;
    
    public int people = 0;

    public int wcpop = 0;

    public int fmpop = 0;

    private int house1 = 0;

    private int house2 = 0;

    private int farm = 0;

    // Use this for initialization
    void Start () {
        popText = GameObject.Find("population");
        wcText = GameObject.Find("woodcutter");
        fmText = GameObject.Find("Farmer");
        ho1Text = GameObject.Find("house1");
        ho2Text = GameObject.Find("house2");
        faText = GameObject.Find("farm");
        Pplm = GameObject.Find("PeopleManager");
    }
	
	// Update is called once per frame
	void Update () {
	}
    
    public void PeopleAction()
    {
        people += 1;
        popText.GetComponent<Text>().text = "人口：" + people + "/" + PeopleMax;
    }

    public void WCsubAction()
    {
        if (wcpop > 0)
        {
            wcpop -= 1;
        }
        wcText.GetComponent<Text>().text = "木こり：" + wcpop;
    }

    public void WCsumAction()
    {
        if (wcpop < PeopleMax)
        {
            wcpop += 1;
        }
        wcText.GetComponent<Text>().text = "木こり：" + wcpop;
        Pplm.GetComponent<PeopleManager>().WoodCutterB();
    }

    public void FMsubAction()
    {
        if (fmpop > 0)
        {
            fmpop -= 1;
        }
        fmText.GetComponent<Text>().text = "農家：" + fmpop;
    }

    public void FMsumAction()
    {
        if (fmpop < PeopleMax)
        {
            fmpop += 1;
        }
        fmText.GetComponent<Text>().text = "農家：" + fmpop;
        Pplm.GetComponent<PeopleManager>().WoodCutterB();
    }

    public void House1Action()
    {
        house1 += 1;
        PeopleMax += 3;
        ho1Text.GetComponent<Text>().text = "家1数：" + house1;
    }

    public void House2Action()
    {
        house2 += 1;
        PeopleMax += 6;
        ho2Text.GetComponent<Text>().text = "家2数：" + house2;
    }

    public void FarmAction()
    {
        farm += 1;
        faText.GetComponent<Text>().text = "畑 数：" + farm;
    }
}
