using UnityEngine;
using System.Collections;

public class HexUIClick : MonoBehaviour
{
    GameObject hexSlideOut1;
    bool slide = false;
    public float speed = 5.0f;

    // Use this for initialization
    void Start()
    {
        hexSlideOut1 = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (slide)
            hexSlideOut1.transform.position = Vector3.Lerp(hexSlideOut1.transform.position, (hexSlideOut1.transform.position + new Vector3(-1.25f, 0.0f, 0.0f)), Time.deltaTime * speed);
    }

    void OnMouseDown()
    {
        slide = true;
    }

}