using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPathFollow : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    [SerializeField]
    int initialWaypoint;
    private int currentWaypoint;
    [SerializeField]
    float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = initialWaypoint;
        speed = speed * Random.Range(.9f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWaypoint].position ) < 0.2)
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length;
        }
        transform.Translate((waypoints[currentWaypoint].position - transform.position).normalized* speed,Space.World);
        transform.LookAt(waypoints[currentWaypoint]);
    }
}
