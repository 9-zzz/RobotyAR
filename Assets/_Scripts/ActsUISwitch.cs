using UnityEngine;
using System.Collections;

public class ActsUISwitch : MonoBehaviour
{
    public int contextIn;

    public GameObject ARCamera;
    public GameObject HexUICamera;
    public GameObject AstarCamera;

    void OnMouseDown()
    {
        ARCamera.SetActive(false);
        HexUICamera.SetActive(true); // ACT takes to the hexagons.
        AstarCamera.SetActive(false);
    }

    void Start()
    {

    }

    void Update()
    {

    }

}
