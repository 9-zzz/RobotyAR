using UnityEngine;
using System.Collections;

public class Unit: MonoBehaviour
{


    public Transform target;
    float speed = 1;
    Vector3[] path;
    int targetIndex;
    public int count;

    Ray ray;
    RaycastHit hit;

    void Start()
    {
        PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);

   

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            print(hit.collider.name);
        }
    }

    public void OnPathFound(Vector3[] newPath, bool pathSuccessful)
    {
        if (pathSuccessful)
        {
            path = newPath;
            //StopCoroutine("FollowPath");
            //StartCoroutine("FollowPath");
        }
    }

    IEnumerator FollowPath()
    {
        Vector3 currentWaypoint = path[0];

        while (true)
        {
            if (transform.position == currentWaypoint)
            {
                targetIndex++;
                if (targetIndex >= path.Length)
                {
                    yield break;
                }
                currentWaypoint = path[targetIndex];
            }

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, speed * Time.deltaTime);
            yield return null;

        }
    }

    public void OnMouseDown()
    {
        //UnitTargetManager.S.SetNewTarget(this.gameObject, UnitTargetManager.S.coke);

        

        if (gameObject.name == "pepsi")
            count++;
        //UnitTargetManager.S.pepsiVotes++;

        if (gameObject.name == "coke")
            count++;
        //UnitTargetManager.S.cokeVotes++;

        if (gameObject.name == "seeker")
        {
           // target = GameObject.Find("pepsi").transform;
            //count++;
        }
            //UnitTargetManager.S.homeVotes++;
    }

    public void OnMouseUp()
    {
        if (gameObject.name == "pepsi")
        {
            hit.transform.GetChild(0).GetComponent<TextMesh>().text = "hello";
            target = hit.collider.transform;
            
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
        }
        if (gameObject.name == "coke")
        {
            target = hit.collider.transform;
            hit.transform.GetChild(0).GetComponent<TextMesh>().text = "hello";
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
        }
        if (gameObject.name == "seeker")
        {
            target = hit.collider.transform;
            hit.transform.GetChild(0).GetComponent<TextMesh>().text = "hello";
            PathRequestManager.RequestPath(transform.position, target.position, OnPathFound);
        }
    }

    public void OnDrawGizmos()
    {
        if (path != null)
        {
            for (int i = targetIndex; i < path.Length; i++)
            {
                if(target.GetComponent<BehaviorNode>().rank == 1)
                    Gizmos.color = Color.blue;
                if (target.GetComponent<BehaviorNode>().rank == 2)
                    Gizmos.color = Color.red;
               
                
                Gizmos.DrawCube(path[i], Vector3.one);

                if (i == targetIndex)
                {
                    Gizmos.DrawLine(transform.position, path[i]);
                }
                else {
                    Gizmos.DrawLine(path[i - 1], path[i]);
                }
            }
        }
    }
}
