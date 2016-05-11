using UnityEngine;
using System.Collections;

public class BehaviorNode : MonoBehaviour
{
    public string behavior;
    public int rank;
    public float value;

    public BehaviorNode(string behavior, int rank, float value)
    {
        this.behavior = behavior;
        this.rank = rank;
        this.value = value;
    }

}
