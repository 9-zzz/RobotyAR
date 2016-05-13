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

        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeFiducial();
            fiducial_2.transform.GetChild(0).GetComponent<LineRenderer>().enabled = false;
            fiducial_1.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto"+"\n"+"B";
        }


       /* if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeFiducial();
            fiducial_2.transform.GetChild(0).GetComponent<LineRenderer>().enabled = false;
            fiducial_1.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto" + "\n" + "B";
        }
        */

    }

    public void ChangeFiducial()
    {
        fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_3;
    }

    void OnMouseUp()
    {

    }
}
