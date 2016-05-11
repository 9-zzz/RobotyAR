using UnityEngine;
using System.Collections;

public class SlotChildPositionCheckZero : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (transform.childCount >= 1)
            transform.GetChild(0).localPosition = Vector3.zero;

        //transform.GetChild(0).localPosition = Vector3.MoveTowards(transform.GetChild(0).localPosition, Vector3.zero, Time.deltaTime * 5.0f);
    }

}
