using UnityEngine;
using System.Collections;

public class DrawALine : MonoBehaviour
{



    public GameObject objA;
    public GameObject objB;
    public Color c1 = Color.red;
    LineRenderer lineRenderer;
    public int num;


    void Awake()
    {
        lineRenderer = (LineRenderer)this.GetComponent(typeof(LineRenderer));
    }
    // Use this for initialization
    void Start()
    {

        if (objA == null || objB == null)
            throw new System.Exception("You must assign two GameObjects");


        lineRenderer.material = new Material(Shader.Find("Particles/Alpha Blended"));
        //lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        lineRenderer.SetColors(Color.red, Color.red);


    }

  

    void Update()
    {

       // if(Input.GetMouseButtonUp(0))

        if (num == 0)
        {
            Vector3 offset = new Vector3(0, 0, 0.5f);
            lineRenderer.SetPosition(0, objA.transform.position + offset);
            lineRenderer.SetPosition(1, objB.transform.position + offset);
            lineRenderer.SetColors(Color.red, Color.red);
        }

        if (num == 1)
        {
            Vector3 offset2 = new Vector3(0, 0, 0.5f);
            lineRenderer.SetPosition(0, objA.transform.position + offset2);
            lineRenderer.SetPosition(1, objB.transform.position + offset2);
            lineRenderer.SetColors(Color.green, Color.green);
        }

        if (num == 2)
        {
            Vector3 offset = new Vector3(0, 0, -0.5f);
            lineRenderer.SetPosition(0, objA.transform.position + offset);
            lineRenderer.SetPosition(1, objB.transform.position + offset);
            lineRenderer.SetColors(Color.blue, Color.blue);
        }

        if (num == 3)
        {
            Vector3 offset = new Vector3(0, 0, -0.5f);
            lineRenderer.SetPosition(0, objA.transform.position + offset);
            lineRenderer.SetPosition(1, objB.transform.position + offset);
            lineRenderer.SetColors(Color.black, Color.black);
        }
    }
}