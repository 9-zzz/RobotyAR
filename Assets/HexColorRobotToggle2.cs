using UnityEngine;
using System.Collections;

public class HexColorRobotToggle2 : MonoBehaviour
{

    public Material newMat;
    public Material originalMat;
    public bool flag = false;

    // Use this for initialization
    void Start()
    {
        originalMat = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (!flag)
        {
            GetComponent<MeshRenderer>().material = newMat;
            HexColorRobotToggle.S.GetComponent<MeshRenderer>().material = originalMat;
            //flag = true;
        }

    }

}
