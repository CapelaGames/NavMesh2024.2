using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] //Nice to have
public class FollowPlayer : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;

    private void Start()
    {
       agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       /* if (agent.pathPending || !agent.isOnNavMesh || agent.remainingDistance > 0.1f)
        {
            //exit function (update) here
            //we want to exit if we currently have a path
            return;
        }*/
        agent.destination = goal.position;
    }
}
