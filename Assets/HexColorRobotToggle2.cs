using UnityEngine;
using System.Collections;

public class HexColorRobotToggle2 : MonoBehaviour
{

    public Material newMat;
    public Material originalMat;

    void Start()
    {
        originalMat = GetComponent<MeshRenderer>().materials[0];
    }

    void Update()
    {

    }

    void OnMouseDown()
    {
            GetComponent<MeshRenderer>().material = newMat;
            HexColorRobotToggle.S.GetComponent<MeshRenderer>().material = originalMat;
    }

}
