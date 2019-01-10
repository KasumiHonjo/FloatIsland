using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public enum carcterstate
{
    wait, move, Wwork,Fwork
}

public class PeopleControler : MonoBehaviour {

    public carcterstate state;
    public GameObject[] TTargets;
    public GameObject[] FTargets;
    public GameObject Target;
    public GameObject GM;

    public GameObject PPLM;

    private int wc;
    private int fm;
    private int wst = 0;
    private int fst = 0;

    NavMeshAgent mynav;

    private Animator myAnimator;

    // Use this for initialization
    void Start () {
        TTargets = GameObject.FindGameObjectsWithTag("Tree");
        FTargets = GameObject.FindGameObjectsWithTag("Farm");

        mynav = GetComponent<NavMeshAgent>();

        myAnimator = GetComponent<Animator>();

        GM = GameObject.Find("GameManeger");
        wc = GM.GetComponent<GameManager>().wcpop;
        fm = GM.GetComponent<GameManager>().fmpop;

        PPLM = GameObject.Find("PeopleManager");
        PPLM.GetComponent<PeopleManager>().people.Add(gameObject);
        
    }
	
	// Update is called once per frame
	void Update () {

        switch (state)
        {
            case carcterstate.wait:
                myAnimator.SetTrigger("WaitTrigger");
                break;
            case carcterstate.move:
                if(Vector3.Distance(transform.position, Target.transform.position) < 1f)
                {
                    state = carcterstate.Wwork;
                }
                myAnimator.SetTrigger("MoveTrigger");
                break;
            case carcterstate.Wwork:
                myAnimator.SetTrigger("WorkTrigger");
                break;
            case carcterstate.Fwork:
                myAnimator.SetTrigger("WorkTrigger");
                break;

        }

	}

    public void JobCheck()
    {
        PPLM = GameObject.Find("PeopleManager");
        wst = PPLM.GetComponent<PeopleManager>().wstate;
        fst = PPLM.GetComponent<PeopleManager>().fstate;

        if (wc <= wst)
        {
            SetTTarget();
        }
        else if(fm <= fst)
        {
            SetFTarget();
        }
    }

    public void SetTTarget()
    {
        if (mynav.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            int rads = Random.Range(0, TTargets.Length);
            Target = TTargets[rads];
            mynav.SetDestination(TTargets[rads].transform.position);
            Debug.Log(TTargets[rads].transform.position);
            state = carcterstate.move;
            PPLM.GetComponent<PeopleManager>().wstate++;
        }
    }

    public void SetFTarget()
    {
        if (mynav.pathStatus != NavMeshPathStatus.PathInvalid)
        {
            int rads = Random.Range(0, FTargets.Length);
            Target = FTargets[rads];
            mynav.SetDestination(FTargets[rads].transform.position);
            Debug.Log(FTargets[rads].transform.position);
            state = carcterstate.move;
            PPLM.GetComponent<PeopleManager>().fstate++;
        }
    }

}
