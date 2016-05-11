using UnityEngine;
using System.Collections;

public class PlayButtonClickServer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown()
    {
        networkSocket.S.BufferThing();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
