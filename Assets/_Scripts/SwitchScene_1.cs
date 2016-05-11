using UnityEngine;
using System.Collections;

public class SwitchScene_1 : MonoBehaviour
{
    public GameObject ARCamera;
    public GameObject NormalCamera;

    void OnMouseDown()
    {
        ARCamera.SetActive(!ARCamera.activeSelf);
        NormalCamera.SetActive(!NormalCamera.activeSelf);
    }

    void Start()
    {

    }

    void Update()
    {

    }

}
