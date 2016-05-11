using UnityEngine;
using System.Collections;

public class ARUIClickMenuTL : MonoBehaviour
{
    public static ARUIClickMenuTL S;

    public GameObject[] prefabs;
    GameObject brainNode;
    float ctrOffset = 1.25f;

    bool flag = true;
    // Use this for initialization
    void Start()
    {
        S = this;
    }

    void OnMouseDown()
    {
        JSONParser.S.fileFlag = 0;
        JSONParser.S.SetFlags();
        if (flag)
        {

            networkSocket.S.input_buffer = "";
            for (int i = 0; i < 2; i++)
            {
                brainNode = Instantiate(prefabs[i], transform.position + (Vector3.left * -ctrOffset), prefabs[i].transform.rotation) as GameObject;

                brainNode.transform.Rotate(180, 180, 0);

                //brainNode.transform.localScale = 

                brainNode.transform.parent = this.transform;

                brainNode.transform.localScale *= 2;
                ctrOffset += 1.25f;
                string temp =  JSONParser.S.brain.behaviors[i].behavior;
                networkSocket.S.input_buffer += temp;
                brainNode.transform.GetChild(0).GetComponent<TextMesh>().text = temp;

            }

            flag = false;
        }
        else
        {
            DestroyChildren(transform.gameObject);
            ctrOffset = 1.0f;
            flag = true;
        }
    }
    public void DestroyChildren(GameObject parent)
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            Destroy(parent.transform.GetChild(i).gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
