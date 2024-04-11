using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWaypoint : MonoBehaviour
{
    public Transform[] waypoints;
    public bool loop = false;

    private UnityEngine.AI.NavMeshAgent agent;
    private int waypointCount, waypointIteration;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(waypoints[0].position);

        waypointCount = waypoints.Length;
        waypointIteration = 0;
    }

    void Update()
    {
        if (agent.hasPath)
        {
            if (agent.remainingDistance < .5f)
            {
                if (waypointIteration < waypointCount)
                {
                    agent.SetDestination(waypoints[waypointIteration].position);
                    waypointIteration++;
                }
                else
                {
                    if (loop)
                    {
                        waypointIteration = 0;
                    }
                }
            }
        }
    }
}
