using UnityEngine;
using System.Collections;

public class CubeColliderUpdate : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Physics.IgnoreCollision(this.GetComponent<Collider>(), transform.parent.GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "RedCube")
        {
            transform.Translate(0, 0, -2.0f);
            transform.localScale = Vector3.one;

            print("HIT");
            this.gameObject.layer = 8;
           // Grid.S.CreateGrid();
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RedCube")
        {
            print("EXITED");
            transform.localPosition = Vector3.zero;
            transform.localScale =new Vector3(1.5f,1.0f,1.5f);
            this.gameObject.layer = 0;
            //Grid.S.CreateGrid();
        }
    }

}
