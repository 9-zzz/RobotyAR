using UnityEngine;
using System.Collections;

public class MouseUpChangeFiducial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp()
    {
        FiducialTargetManager.S.ChangeFiducial();
    }
}
