using UnityEngine;
using System.Collections;

public class FiducialTargetManager : MonoBehaviour {

    public GameObject fiducial_1;
    public GameObject fiducial_2;
    public GameObject fiducial_3;
    public static FiducialTargetManager S;

	// Use this for initialization
	void Start () {
        S = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeFiducial()
    {
        fiducial_1.transform.GetComponent<DrawALine>().objB = fiducial_3;
    }

    void OnMouseUp()
    {

    }
}
