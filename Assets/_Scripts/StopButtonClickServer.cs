using UnityEngine;
using System.Collections;

public class StopButtonClickServer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown()
    {
        networkSocket.S.input_buffer = "STOP";
        networkSocket.S.BufferThing();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
