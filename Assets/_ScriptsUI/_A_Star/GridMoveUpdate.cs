using UnityEngine;
using System.Collections;

public class GridMoveUpdate : MonoBehaviour {

    Vector3 curPos;
    Vector3 lastPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
            curPos = transform.position;
            if (curPos == lastPos)
            {
                //print("Not moving");
            }
        else
        {
            //print("IT MOVED#####!!!");
           // Grid.S.CreateGrid();
        }
            lastPos = curPos;
        

    }
}
