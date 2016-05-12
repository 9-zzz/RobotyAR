using UnityEngine;
using System.Collections;


public class UnitTargetManager : MonoBehaviour
{

    public static UnitTargetManager S;
    

    public GameObject home;
    public GameObject coke;
    public GameObject pepsi;
    public GameObject[] missionOrder;


    public int homeVotes = 0;
    public int cokeVotes = 0;
    public int pepsiVotes = 0;

    void Awake()
    {
        S = this;
    }

    public void SetNewTarget(GameObject toSetTarget, GameObject newTarget)
    {
        toSetTarget.GetComponent<Unit>().target = newTarget.transform; 
    }

    public void sort()
    {
        if (home.GetComponent<Unit>().count < pepsi.GetComponent<Unit>().count)
        {
            GameObject temp = missionOrder[0];
            missionOrder[0] = missionOrder[1];
            missionOrder[1] = temp;

            SetNewTarget(pepsi, home);
            SetNewTarget(home, coke);
            //SetNewTarget(home, coke);
        }

    }

    void Start()
    {
        missionOrder = new GameObject[10];
        missionOrder[0] = home;
        missionOrder[1] = pepsi;
        missionOrder[2] = coke;
    }

    void Update()
    {
        //print("Home: " + home.GetComponent<Unit>().count + " Pepsi: " + pepsi.GetComponent<Unit>().count + " Coke: " + coke.GetComponent<Unit>().count);
        sort();
    }    
}