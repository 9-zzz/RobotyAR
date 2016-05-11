using UnityEngine;
using System.Collections;
using System.IO;
using JSON;

public class JSONParser : MonoBehaviour
{


    public static JSONParser S;

    //[SerializeField]
    public Brain brain = null;
    public int fileFlag = 0;

    void Awake()
    {
        S = this;
    }

    public void SetFlags()
    {

        if (fileFlag == 0)
        {
            string json = File.ReadAllText(Path.Combine(Application.dataPath, "atree.json"));
            this.brain = (Brain)JSONSerialize.Deserialize(typeof(Brain), json);
        }
        else if (fileFlag == 1)
        {
            string json = File.ReadAllText(Path.Combine(Application.dataPath, "btree.json"));
            this.brain = (Brain)JSONSerialize.Deserialize(typeof(Brain), json);
        }
        else if (fileFlag == 2)
        {
            string json = File.ReadAllText(Path.Combine(Application.dataPath, "ctree.json"));
            this.brain = (Brain)JSONSerialize.Deserialize(typeof(Brain), json);
        }

        //print(json);

        for (int i = 0; i < 4; i++)
        {
            print(this.brain.behaviors[i].behavior);
        }
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) { JSONSerialize.Serialize(Path.Combine(Application.dataPath, "configNew.json"), this.person); }
    }


}
