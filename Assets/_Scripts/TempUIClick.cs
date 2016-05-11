using UnityEngine;
using System.Collections;

public class TempUIClick : MonoBehaviour {

    void OnMouseDown()
    {
        AffordanceUI.S.callfromtempCollider();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
