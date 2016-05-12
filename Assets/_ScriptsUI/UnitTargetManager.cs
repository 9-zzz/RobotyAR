using UnityEngine;
using System.Collections;


public class UnitTargetManager : MonoBehaviour
{

    public static UnitTargetManager S;
    

    public GameObject[] homes;
    public GameObject[] cokes;
    public GameObject[] pepsis;
    public GameObject[] missionOrder;


    public int homeVotes = 0;
    public int cokeVotes = 0;
    public int pepsiVotes = 0;

    void Awake()
    {
        S = this;
    }

    int homeCount = 0;
    public void SetNewTarget(GameObject curr, GameObject newTarget, string behavior, int rank, string currName)
    {
       // print(behavior);
       //print(rank);

        curr.transform.GetComponent<Unit>().target = newTarget.transform;
        curr.GetComponent<BehaviorNode>().rank = rank;
        curr.GetComponent<BehaviorNode>().behavior = behavior;
        curr.GetComponent<BehaviorNode>().curr = currName;
        curr.transform.GetChild(0).GetComponent<TextMesh>().text = rank.ToString();

  
    }

    public void sort()
    {

    }

    GameObject getNextTarget(string behavior)
    {
        if (behavior == "Go to Home")
        {       
            GameObject temp = homes[homeCount];
            homeCount++;
            return temp;   
        }
        else if (behavior == "Go to Pepsi")
        {
            return pepsis[0];
          
        }
        else if (behavior == "Go to Coke")
        {
            return cokes[0];
        }
        else
        {
            return null;
        }
    }

    void Start()
    {
        missionOrder = new GameObject[10];
        //missionOrder[0] = home;
        //missionOrder[1] = pepsi;
        //missionOrder[2] = coke;

        for (int i = 0; i < 4; i++)
        {
            string temp = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().behavior;
           
            int rank = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().rank;

            string curr = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().curr;
            print(curr);


          
            if(curr == "home")
            {
                SetNewTarget(homes[homeCount], getNextTarget(temp), temp, rank, curr);
            }
            if (curr == "pepsi")
            {
                SetNewTarget(pepsis[0], getNextTarget(temp), temp, rank, curr);
            }
            if (curr == "coke")
            {
                SetNewTarget(cokes[0], getNextTarget(temp), temp, rank, curr);
            }
        }
    }

    void Update()
    {
        //print("Home: " + home.GetComponent<Unit>().count + " Pepsi: " + pepsi.GetComponent<Unit>().count + " Coke: " + coke.GetComponent<Unit>().count);
        // sort();
        homeCount = 0;
        if (Input.GetKeyDown(KeyCode.Space)) { 
            for (int i = 0; i < 4; i++)
            {
                string temp = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().behavior;

                int rank = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().rank;

                string curr = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().curr;
                if (curr == "home")
                {
                    SetNewTarget(homes[homeCount], getNextTarget(temp), temp, rank, curr);

                }

                if (curr == "pepsi")
                {
                    SetNewTarget(pepsis[0], getNextTarget(temp), temp, rank, curr);
                }

                if (curr == "coke")
                {
                    SetNewTarget(cokes[0], getNextTarget(temp), temp, rank, curr);
                }
            }
        }
    }
}