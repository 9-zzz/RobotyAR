using UnityEngine;
using System.Collections;

public class PopulateSlotsWithUINodes : MonoBehaviour
{
    public static PopulateSlotsWithUINodes S;
    public Color colorT;
    public int fontSize;
    public GameObject[] missionOrder;
    //public Font fontT;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().text = "BLANK";
            transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().color = colorT;
            transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().fontSize = fontSize;
            //transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().font = fontT;
        }

        networkSocket.S.input_buffer = "";

        print("populate thing happens first");
        for (int i = 0; i < 4; i++)
        {
            string temp = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().behavior;

            transform.GetChild(i).GetChild(0).GetComponent<DragAndDropHex>().rank = BehaviorManager.S.BNodes[i].GetComponent<BehaviorNode>().rank;

            networkSocket.S.input_buffer += temp;

            transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().text = temp.ToUpper();
        }
    }

    public void RefreshMissionOrderArray()
    {
        for (int i = 0; i < transform.childCount; i++)
            missionOrder[i] = transform.GetChild(i).GetChild(0).gameObject;
    }

    void ReadHexUIs()
    {
        var tmpstr = "";

        for (int i = 0; i < transform.childCount; i++)
        {
            tmpstr += transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<TextMesh>().text + "_";
        }

        networkSocket.S.input_buffer = tmpstr;
        networkSocket.S.BufferThing();

        print(tmpstr);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            ReadHexUIs();

        if (Input.GetKeyDown(KeyCode.R))
            RefreshMissionOrderArray();
    }

}
