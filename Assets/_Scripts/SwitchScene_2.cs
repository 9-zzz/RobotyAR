using UnityEngine;
using System.Collections;

public class SwitchScene_2 : MonoBehaviour
{
    public GameObject ARCamera;
    public GameObject ASTARCAM;

    void OnMouseDown()
    {
        ARCamera.SetActive(!ARCamera.activeSelf);
        ASTARCAM.SetActive(!ASTARCAM.activeSelf);
    }

}
