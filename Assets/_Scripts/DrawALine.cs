using UnityEngine;
using System.Collections;

public class DrawALine : MonoBehaviour
{

    public GameObject objA;
    public GameObject objB;

    LineRenderer lineRenderer;

    void Awake()
    {
        lineRenderer = (LineRenderer)this.GetComponent(typeof(LineRenderer));
    }
    // Use this for initialization
    void Start()
    {

        if (objA == null || objB == null)
            throw new System.Exception("You must assign two GameObjects");


    }


    void Update()
    {

        lineRenderer.SetPosition(0, objA.transform.position);
        lineRenderer.SetPosition(1, objB.transform.position);

    }
}