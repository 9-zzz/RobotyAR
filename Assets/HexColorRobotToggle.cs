using UnityEngine;
using System.Collections;

public class HexColorRobotToggle : MonoBehaviour
{

    public static HexColorRobotToggle S;
    public Material newMat;
    public Material originalMat;

    // Use this for initialization
    void Start()
    {
        S = this;
        originalMat = GetComponent<MeshRenderer>().materials[1];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        print("colr");
        GetComponent<MeshRenderer>().material = newMat;
        //GetComponent<MeshRenderer>().material.color = Color.blue;
    }

}
