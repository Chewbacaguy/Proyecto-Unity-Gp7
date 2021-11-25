using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f;
    private int lastWaypointIndex;
    private float time = 0f;
    public float timer = 0f;
    public float delay = 0f;
    public bool stop = false;

    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        targetWaypoint = waypoints[targetWaypointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if(time/24 == timer)
        {
            stop = true;
        }
        if(time/24 == timer+delay)
        {
            stop = false;
            // time = 0f;
        }
        if(stop == false)
        {
            speed = 5.0f;
            transform.position = Vector3.MoveTowards(transform.position,targetWaypoint.position,Time.deltaTime*speed);
            if(Vector3.Distance(transform.position,targetWaypoint.position) < minDistance)
            {
                targetWaypointIndex++;
                if(targetWaypointIndex >= waypoints.Count)
                {
                    targetWaypointIndex = 0;
                }
                targetWaypoint = waypoints[targetWaypointIndex];
            }
        }
        else
        {
            speed = 0;
        }
        time++;
    }
}