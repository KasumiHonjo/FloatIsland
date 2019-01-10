using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PeopleManager : MonoBehaviour {
    
    public List<GameObject> people = new List<GameObject>();

    public GameObject GM;
    
    public int wstate = 0;
    public int fstate = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //people = GameObject.FindGameObjectsWithTag("People").ToList();
    }

    public void WoodCutterB()
    {
        GameObject waitppl = Getwaitppl();
        if (waitppl != null)
        {
            waitppl.GetComponent<PeopleControler>().JobCheck();
            //waitppl.GetComponent<PeopleControler>().state = carcterstate.move;
        }
    }

    private GameObject Getwaitppl()
    {
        for(int i = 0; i < people.Count; i++)
        {
            PeopleControler ppl = people[i].GetComponent<PeopleControler>();
            if(ppl.state == carcterstate.wait)
            {
                return people[i];
            }
            /*if(ppl.state == carcterstate.Wwork)
            {
                wstate++;
            }
            else if (ppl.state == carcterstate.Fwork)
            {
                fstate++;
            }*/
        }
        return null;
    }
    
}
