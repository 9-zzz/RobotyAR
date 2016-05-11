using UnityEngine;
using System.Collections;

public class BehaviorManager : MonoBehaviour
{
    public static BehaviorManager S;

    public int len;
    public GameObject[] BNodes;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        len = 4;

        JSONParser.S.fileFlag = 0;
        JSONParser.S.SetFlags();

        print("behavior manager happens first");
        for (int i = 0; i < len; i++)
        {
            BNodes[i].GetComponent<BehaviorNode>().behavior = JSONParser.S.brain.behaviors[i].behavior;
            BNodes[i].GetComponent<BehaviorNode>().rank = i;
            //BNodes[i].GetComponent<BehaviorNode>().value = float.Parse(JSONParser.S.brain.behaviors[i].likelihood, System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    public void ReRank()
    {
        for (int i = 0; i < len; i++)
        {
            BNodes[i].GetComponent<BehaviorNode>().rank = i;
        }
    }

    void Update()
    {

    }

}
