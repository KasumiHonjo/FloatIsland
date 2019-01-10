using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectButton : MonoBehaviour {

    public GameObject WC;
    public GameObject FM;

    public int buttonname;

	// Use this for initialization
	void Start () {
        buttonname = 1;
        WC = GameObject.Find("Job");
        FM = GameObject.Find("Job");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(int number)
    {
        switch (number)
        {
            case 1:
                buttonname = number;
                Debug.Log(buttonname);
                break;
            case 2:
                buttonname = number;
                Debug.Log(buttonname);
                break;
            case 3:
                buttonname = number;
                Debug.Log(buttonname);
                break;
            case 4:
                buttonname = number;
                WC.GetComponent<WoodCutter>().WCsub();
                Debug.Log(buttonname);
                break;
            case 5:
                buttonname = number;
                WC.GetComponent<WoodCutter>().WCsum();
                Debug.Log(buttonname);
                break;
            case 6:
                buttonname = number;
                FM.GetComponent<Farmer>().FMsub();
                Debug.Log(buttonname);
                break;
            case 7:
                buttonname = number;
                FM.GetComponent<Farmer>().FMsum();
                Debug.Log(buttonname);
                break;
            default:
                break;
        }
    }
}
