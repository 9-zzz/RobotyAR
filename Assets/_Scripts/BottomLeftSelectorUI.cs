using UnityEngine;
using System.Collections;

public class BottomLeftSelectorUI : MonoBehaviour
{
    public bool flag = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        flag = !flag;
        print(flag.ToString());
    }

}
