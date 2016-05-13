using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AffordanceUI : MonoBehaviour
{
    public static AffordanceUI S;

    //bool clicked = false;

    public GameObject ARContainer;
    public GameObject brainRef;
    public GameObject prefab;
    private GameObject brainNode;

    void Awake() { S = this; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() // no mroe
    {
        for (int i = 0; i < 4; i++)
        {
            //Transform offset = this.transform;

            //brainNode = (GameObject)Instantiate(prefab, brainRef.transform.position - ((brainRef.transform.up) * i * 100), this.transform.rotation);
            brainNode = (GameObject)Instantiate(prefab, ARContainer.transform.position, ARContainer.transform.rotation);

            //brainNode.transform.SetParent(brainRef.transform);
            brainNode.transform.SetParent(ARContainer.transform.GetChild(i).transform);
            brainNode.transform.localPosition = Vector3.zero;

            //brainNode.transform.GetChild(1).GetComponent<Text>().text = JSONParser.S.brain.behaviors[i].behavior;
            brainNode.transform.GetChild(0).GetComponent<TextMesh>().text = JSONParser.S.brain.behaviors[i].behavior;
        }

    }

    public void callfromtempCollider()
    {
        JSONParser.S.fileFlag = 1;
        JSONParser.S.SetFlags();
        networkSocket.S.input_buffer = "";
        for (int i = 0; i < 4; i++)
        {
            brainNode = (GameObject)Instantiate(prefab, ARContainer.transform.position, ARContainer.transform.rotation);

            brainNode.transform.SetParent(ARContainer.transform.GetChild(i).transform);
            brainNode.transform.localPosition = Vector3.zero;

            string temp = JSONParser.S.brain.behaviors[i].behavior;
            networkSocket.S.input_buffer += temp;
            brainNode.transform.GetChild(0).GetComponent<TextMesh>().text = temp;
        }

    }

    public void callfromtempColliderTwo()
    {
        JSONParser.S.fileFlag = 2;
        JSONParser.S.SetFlags();
        networkSocket.S.input_buffer = "";
        for (int i = 0; i < 4; i++)
        {
            //brainNode = (GameObject)Instantiate(prefab, ARContainer.transform.position, ARContainer.transform.rotation);

            //brainNode.transform.SetParent(ARContainer.transform.GetChild(i).transform);
            //brainNode.transform.localPosition = Vector3.zero;

            string temp = JSONParser.S.brain.behaviors[i].behavior;
            networkSocket.S.input_buffer += temp;
            brainNode.transform.GetChild(0).GetComponent<TextMesh>().text = JSONParser.S.brain.behaviors[i].behavior;
        }
    }

    void DestroyChildren(GameObject parent)
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            Destroy(parent.transform.GetChild(i).gameObject);

        }
    }
    
}
