using UnityEngine;
using System.Collections;

public class TempUIClickTwo : MonoBehaviour {

    public GameObject container;

    void OnMouseDown()
    {
        //ARUIClickMenuTL.S.DestroyChildren(ARUIClickMenuTL.S.transform.gameObject);
        AffordanceUI.S.callfromtempColliderTwo();
    }

    // Use this for initialization
    void Start()
    {
        container = GameObject.Find("ImageTarget").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

}