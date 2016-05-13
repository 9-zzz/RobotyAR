using UnityEngine;
using System.Collections;

public class FiducialTargetManager : MonoBehaviour {

    public GameObject fiducial_1;
    public GameObject fiducial_2;
    public GameObject fiducial_3;
    public GameObject fiducial_4;
    public GameObject fiducial_5;
    public GameObject fiducial_6;
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


        if (Input.GetKeyDown(KeyCode.M))
        {
            //fiducial_2.transform.GetChild(0).GetComponent<LineRenderer>().enabled = true;
            fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_4;
            fiducial_1.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go \nto" + "\n" + "C";
        }

         if (Input.GetKeyDown(KeyCode.J))
        {
            fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_4;
            fiducial_1.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go\nto\n?";
            fiducial_1.transform.GetChild(3).GetChild(0).GetComponent<TextMesh>().text = "Go\nto\n?";
        }
        

    }

    public void ChangeFiducial()
    {
        fiducial_1.transform.GetChild(1).GetComponent<DrawALine>().objB = fiducial_3;
    }

    void OnMouseUp()
    {

    }
}
