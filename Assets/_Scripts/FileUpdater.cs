/*
using UnityEngine;
using System.Collections;

public class FileUpdater : MonoBehaviour {
    //public GameObject textWriterRef;
    public GameObject agent;

    void Awake()
    {
        agent = GameObject.Find("my_cube");
    }

    void LateUpdate()
    {
        GetComponent<FileWriter>().sw.WriteLine(agent.transform.position.ToString());
        GetComponent<FileWriter>().sw.Flush(); // So I don't have to .Close() and allows me to keep writing to file.
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
*/