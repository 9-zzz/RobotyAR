using UnityEngine;
using System.Collections;

public class PlanUISwitch : MonoBehaviour
{
    public int contextIn;

    public GameObject ARCamera;
    public GameObject HexUICamera;
    public GameObject AstarCamera;

    void OnMouseDown()
    {
        ARCamera.SetActive(false);
        HexUICamera.SetActive(false);
        AstarCamera.SetActive(true);
    }

}
