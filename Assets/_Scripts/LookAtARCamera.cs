using UnityEngine;
using System.Collections;

public class LookAtARCamera : MonoBehaviour {
    public GameObject ARCam;
    Quaternion neededRotation;
    public float rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(ARCam.transform.position);

        neededRotation = Quaternion.LookRotation(ARCam.transform.position - transform.position);

        //use spherical interpollation over time 
        transform.rotation = Quaternion.Slerp(transform.rotation, neededRotation, Time.deltaTime * rotationSpeed);
    }
}
