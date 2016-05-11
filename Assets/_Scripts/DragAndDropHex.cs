using UnityEngine;
using System.Collections;

public class DragAndDropHex : MonoBehaviour
{

    GameObject container;
    public GameObject lastCollidedWith;
    public bool isSelected = false;
    public Vector3 lastPos;
    //Vector3 startingPos;
    float startingZpos;

    public int rank;

    void Start()
    {
        //startingPos = transform.position;
        container = GameObject.Find("container");
        lastPos = transform.position;
        startingZpos = transform.position.z;
    }

    void Update()
    {
        if (isSelected)
        {
            var v3 = Input.mousePosition;
            //v3.z = container.transform.parent.position.z;
            v3.z = startingZpos;
            v3 = Camera.main.ScreenToWorldPoint(v3);
            //v3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = v3;
        }
    }

    void OnMouseDown()
    {
        isSelected = true;
        transform.parent = null;
    }

    void OnMouseUp()
    {
        isSelected = false;
        //transform.localPosition = startingPos;

        foreach (Transform slot in container.transform)
        {
            if (slot.transform.childCount == 0)
            {
                transform.position = slot.position;
                transform.parent = slot;
            }

        }

        if (lastCollidedWith != null)
        {
            PopulateSlotsWithUINodes.S.RefreshMissionOrderArray();

            GameObject tempNode = BehaviorManager.S.BNodes[rank];
            int temp = rank;
            int tbc = lastCollidedWith.GetComponent<DragAndDropHex>().rank;

            BehaviorManager.S.BNodes[rank] = BehaviorManager.S.BNodes[tbc];
            rank = tbc;

            BehaviorManager.S.BNodes[tbc] = tempNode;
            lastCollidedWith.GetComponent<DragAndDropHex>().rank = temp;

            BehaviorManager.S.ReRank();
        }

        lastCollidedWith = null;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!isSelected)
        {
            if (collision.tag == "UIHEX")
            {
                lastCollidedWith = collision.gameObject;
                collision.gameObject.GetComponent<DragAndDropHex>().lastCollidedWith = this.gameObject;

                foreach (Transform slot in container.transform)
                {
                    if (slot.transform.childCount == 0)
                    {
                        transform.position = slot.position;
                        collision.transform.parent = transform.parent;
                        transform.parent = slot;
                        //print0w("index of " + ); // give value
                    }

                }
            }
        }
    }

    IEnumerator SwapParent(Transform slot)
    {
        yield return new WaitForSeconds(0.1f);
        print("AY! " + slot.gameObject.name);
    }

}
