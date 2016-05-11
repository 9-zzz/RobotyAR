using UnityEngine;
using System.Collections;

public class CameraUISwitch : MonoBehaviour
{
    public int contextIn;

    public GameObject ARCamera;
    public GameObject HexUICamera;
    public GameObject AstarCamera;

    void OnMouseDown()
    {
        ARCamera.SetActive(true);
        HexUICamera.SetActive(false);
        AstarCamera.SetActive(false);
    }

}
